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
        //string used for connectiong to the database
        private string connectionString =
                 Properties.Settings.Default.HotSavDBConnectionString;
        //The method return all available rooms based on the parameters provided
        public ArrayList GetAvailableRooms(DateTime start, DateTime end, int typeOfRoom, bool miniBar)
        {
            ArrayList tmplist = new ArrayList();

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT Room.id from Room WHERE Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE " +
            "@start BETWEEN Booking.startdate AND Booking.enddate) AND Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE " +
            "@end BETWEEN Booking.startdate AND Booking.enddate) AND Room.id IN (SELECT Room.id from Room WHERE Room.roomtype = @typeOfRoom AND Room.minibar = " +
            "@miniBar)", con);

            comm.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            comm.Parameters.Add("@end", SqlDbType.DateTime).Value = end.AddDays(-1);
            comm.Parameters.Add("@typeOfRoom", SqlDbType.Int).Value = typeOfRoom;
            comm.Parameters.Add("@miniBar", SqlDbType.Bit).Value = miniBar;

            try {
                con.Open();
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tmplist.Add(reader.GetInt32(0));
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error", "Failed getting posts");
            }
            finally
            {
                con.Close();
            }
            
            return tmplist;
        }

        public Booking GetBooking(int bookingNr)
        {
            ArrayList tmplist = new ArrayList();
   
            SqlConnection con = new SqlConnection(connectionString);
            
            SqlCommand comm = new SqlCommand("SELECT * from Booking WHERE Booking.Id = @id", con);

            comm.Parameters.Add("@id", SqlDbType.Int).Value = bookingNr;

            try {
                con.Open();
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
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error", "Failed getting post");
            }
            finally
            {
                con.Close();
            }
            
            if (tmplist.Count != 0)
                return new Booking((DateTime)tmplist[1], (DateTime)tmplist[2], (string)tmplist[3], (string)tmplist[4], (int)tmplist[5], (bool)tmplist[6], (DateTime)tmplist[7]);
            else
                return null;  
        }

        internal void UpdatePost(Booking booking)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand("UPDATE Booking(startdate, enddate, firstname, lastname, room, wake, waketime) values (@sd, @ed, @fn, @ln, @rn, @w, @wt) WHERE "+
                    "Booking.startdate = @sd AND Booking.room = @rn", con);
                comm.Parameters.Add("@sd", SqlDbType.DateTime).Value = booking.Startime;
                comm.Parameters.Add("@ed", SqlDbType.DateTime).Value = booking.EndTime;
                comm.Parameters.Add("@fn", SqlDbType.NChar).Value = booking.FirstName;
                comm.Parameters.Add("@ln", SqlDbType.NChar).Value = booking.LastName;
                comm.Parameters.Add("@rn", SqlDbType.Int).Value = booking.BookedId;
                comm.Parameters.Add("@w", SqlDbType.Bit).Value = booking.WakeUp;
                comm.Parameters.Add("@wt", SqlDbType.DateTime).Value = booking.WakeTime;
                try
                {
                    con.Open();
                    comm.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("updated", "true");
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("updated", "false");
                }
                finally
                {
                    con.Close();
                }

            }
        }

        public int DeletePost(int bnr)
        {
            int success = -1;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand("DELETE FROM Booking WHERE Id = @id", con);
                comm.Parameters.Add("@id", SqlDbType.Int).Value = bnr;
      
                try
                {
                    con.Open();
                    success = comm.ExecuteNonQuery();             
                    System.Windows.Forms.MessageBox.Show("Deleted", "Deleted");
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Deleted", "Failed");
                }
                finally
                {
                    con.Close();
                }
                return success;
            }
        }
    
        public int InsertBooking(Booking booking)
        {
            Int32 newId = -1;
             using (SqlConnection con = new SqlConnection(connectionString))
                {
                SqlCommand comm = new SqlCommand("INSERT INTO Booking(startdate, enddate, firstname, lastname, room, wake, waketime) OUTPUT INSERTED.ID values (@sd, @ed, @fn, @ln, @rn, @w, @wt); SELECT NewID = SCOPE_IDENTITY();", con);
                    comm.Parameters.Add("@sd", SqlDbType.DateTime).Value = booking.Startime;
                    comm.Parameters.Add("@ed", SqlDbType.DateTime).Value = booking.EndTime;
                    comm.Parameters.Add("@fn", SqlDbType.NChar).Value = booking.FirstName;
                    comm.Parameters.Add("@ln", SqlDbType.NChar).Value = booking.LastName;
                    comm.Parameters.Add("@rn", SqlDbType.Int).Value = booking.BookedId;
                    comm.Parameters.Add("@w", SqlDbType.Bit).Value = booking.WakeUp;
                    comm.Parameters.Add("@wt", SqlDbType.DateTime).Value = booking.WakeTime;
                try
                {
                    con.Open();
                    newId = (Int32)comm.ExecuteScalar();
                    System.Windows.Forms.MessageBox.Show("inserted", "true");
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("inserted", "false");
                }
                finally
                {
                    con.Close();
                }

                return newId;
            }
        }
    }
}
