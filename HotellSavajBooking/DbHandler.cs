using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections;

namespace HotellSavajBooking
{
    /// <summary>
    /// Class written by Ted Malmgren
    /// 
    /// The class handles all communication with the database.
    /// </summary>
    class DbHandler
    {

        public ArrayList GetAvailableRooms(DateTime start, DateTime end, int typeOfRoom, bool miniBar)
        {
            ArrayList tmplist = new ArrayList();
            int mb = Convert.ToInt32(miniBar);
            string connectionString =
        HotellSavajBooking.Properties.Settings.Default.HotSavDBConnectionString;

            //var s = start.ToShortDateString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT Room.id from Room WHERE Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE '" +
             start + "' BETWEEN Booking.startdate AND Booking.enddate) AND Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE '" +
             end + "' BETWEEN Booking.startdate AND Booking.enddate) AND Room.id IN (SELECT Room.id from Room WHERE Room.roomtype = " + typeOfRoom + " AND Room.minibar = " +
             mb + ")", con);
            //SqlCommand comm = new SqlCommand("SELECT Room.id, startdate, enddate FROM Room inner join Booking on Room.Id = Booking.room WHERE '" +
             //start + "' NOT BETWEEN Booking.startdate AND Booking.enddate", con);
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    tmplist.Add(reader.GetInt32(0));
                }
            }

            con.Close();

            return tmplist;
        }

        public Booking GetBooking(int bookingNr)
        {
            ArrayList tmplist = new ArrayList();
            
            string connectionString =
                HotellSavajBooking.Properties.Settings.Default.HotSavDBConnectionString;

            //var s = start.ToShortDateString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * from Booking WHERE Booking.Id = " + 
                bookingNr + "", con);
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    tmplist.Add(reader.GetInt32(0));
                    tmplist.Add(reader.GetDateTime(1));
                    tmplist.Add(reader.GetDateTime(2));
                    tmplist.Add(reader.GetInt32(5));
                }
            }


            con.Close();
            return new Booking((DateTime)tmplist[1], (DateTime)tmplist[2], new Room((int)tmplist[3], 0, new DateTime(), true));

            
        }
    }
}
