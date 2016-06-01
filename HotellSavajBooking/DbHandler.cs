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
        private string connectionString =
                 Properties.Settings.Default.HotSavDBConnectionString;
        //The method return all available rooms based on the parameters provided
        public ArrayList GetAvailableRooms(DateTime start, DateTime end, int typeOfRoom, bool miniBar)
        {
            ArrayList tmplist = new ArrayList();
            int mb = Convert.ToInt32(miniBar);

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT Room.id from Room WHERE Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE '" +
             start + "' BETWEEN Booking.startdate AND Booking.enddate) AND Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE '" +
             end.AddDays(-1) + "' BETWEEN Booking.startdate AND Booking.enddate) AND Room.id IN (SELECT Room.id from Room WHERE Room.roomtype = " + typeOfRoom + " AND Room.minibar = " +
             mb + ")", con);

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
                    tmplist.Add(reader.GetString(3));
                    tmplist.Add(reader.GetString(4));
                    tmplist.Add(reader.GetInt32(5));
                    tmplist.Add(reader.GetBoolean(6));
                    tmplist.Add(reader.GetDateTime(7));
                }
            }


            con.Close();
            return new Booking((DateTime)tmplist[1], (DateTime)tmplist[2], (string)tmplist[3], (string)tmplist[4], (int)tmplist[5], (bool)tmplist[6], (DateTime)tmplist[7]);     
        }

        public bool InsertBooking(Booking booking)
        {
             using (SqlConnection con = new SqlConnection(connectionString))
                {
                //SqlCommand comm = new SqlCommand("INSERT INTO [Booking](@sd, @ed, @fn, @ln, @rn, @w, @wt)", con);
                SqlCommand comm = new SqlCommand("INSERT INTO Booking(startdate, enddate, firstname, lastname, room, wake, waketime) values (@sd, @ed, @fn, @ln, @rn, @w, @wt)", con);
                    comm.Parameters.Add("@sd", SqlDbType.DateTime).Value = booking.Startime;
                    comm.Parameters.Add("@ed", SqlDbType.DateTime).Value = booking.EndTime;
                    comm.Parameters.Add("@fn", SqlDbType.NChar).Value = booking.FirstName;
                    comm.Parameters.Add("@ln", SqlDbType.NChar).Value = booking.LastName;
                    comm.Parameters.Add("@rn", SqlDbType.Int).Value = booking.BookedId;
                    comm.Parameters.Add("@w", SqlDbType.Bit).Value = booking.WakeUp;
                    comm.Parameters.Add("@wt", SqlDbType.DateTime).Value = booking.WakeTime;
                //"INSERT INTO dbo.Booking (startdate, enddate, firstname, lastname, room, wake, waketime) " +
                //" VALUES ('" + booking.Startime + "', '" + booking.EndTime + "', '" + booking.FirstName + "', '"
                //+ booking.LastName + "', " + booking.BookedId + ", " + 0 + ", '" + booking.WakeTime + "')", con);

                try
                {

                    con.Open();
                    Object success = comm.ExecuteNonQuery();
                    con.Close();
                    System.Windows.Forms.MessageBox.Show("inserted", "true");
                }
            catch
            {
                System.Windows.Forms.MessageBox.Show("inserted", "false");
            }
            return Convert.ToBoolean(true);
        }
        }
    }
}
