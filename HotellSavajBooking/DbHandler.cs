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

        /// <summary>
        /// The method returns all available rooms based on the parameters provided
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="typeOfRoom"></param>
        /// <param name="miniBar"></param>
        /// <returns></returns>
        public ArrayList GetAvailableRooms(DateTime start, DateTime end, int typeOfRoom, bool miniBar)
        {
            ArrayList tmplist = new ArrayList();    //Holds the available rooms returned from the database

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT Room.id from Room WHERE Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE " +
            "@start BETWEEN Booking.startdate AND Booking.enddate) AND Room.id NOT IN (SELECT Room.id FROM Room inner join Booking on Room.Id = Booking.room WHERE " +
            "@end BETWEEN Booking.startdate AND Booking.enddate) AND Room.Id NOT IN (SELECT Room.Id from Room inner join Booking on Room.Id = Booking.room where @start < Booking.startdate AND @end > Booking.enddate) " +
            "AND Room.id IN (SELECT Room.id from Room WHERE Room.roomtype = @typeOfRoom AND Room.minibar = " +
            "@miniBar)", con);

            //Parameters for the query, this prevents sql injections
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
                System.Windows.Forms.MessageBox.Show("Failed getting posts", "Error");
            }
            finally
            {
                con.Close();
            }
            
            return tmplist;
        }

        /// <summary>
        /// The method returns a specific Booking based on the booking id
        /// </summary>
        /// <param name="bookingNr"></param>
        /// <returns></returns>
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
                        tmplist.Add(reader.GetString(3).Trim());
                        tmplist.Add(reader.GetString(4).Trim());
                        tmplist.Add(reader.GetInt32(5));
                        tmplist.Add(reader.GetBoolean(6));
                        tmplist.Add(reader.GetDateTime(7));
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Failed getting post", "Error");
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

        /// <summary>
        /// The method updates a post in the database with the values input in the edit form
        /// </summary>
        /// <param name="booking"></param>
        /// <returns></returns>
        public int UpdatePost(Booking booking, int bnr)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand("UPDATE Booking SET firstname=@fn, lastname=@ln, wake=@w, waketime=@wt" +
                    " WHERE Booking.Id = @id", con);
                comm.Parameters.Add("@fn", SqlDbType.NChar).Value = booking.FirstName;
                comm.Parameters.Add("@ln", SqlDbType.NChar).Value = booking.LastName;
                comm.Parameters.Add("@w", SqlDbType.Bit).Value = booking.WakeUp;
                comm.Parameters.Add("@wt", SqlDbType.DateTime).Value = booking.WakeTime;
                comm.Parameters.Add("@id", SqlDbType.Int).Value = bnr;

                try
                {
                    con.Open();
                    result = comm.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Post was updated successfully!", "Updated");
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("An error occurred, the post was not updated!", "Not Updated");
                }
                finally
                {
                    con.Close();
                }
                return result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bnr"></param>
        /// <returns></returns>
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
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("The deletion failed", "Error");
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
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("An error prevented the post to be saved", "Insertion error");
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
