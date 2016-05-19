using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HotellSavajBooking
{
    class DbHandler
    {

        //public DataTable getAvailableRooms(DateTime start, DateTime end, int typeOfRoom, bool miniBar)
        public void test()
        {
            string connectionString =
        HotellSavajBooking.Properties.Settings.Default.HotSavDBConnectionString;
   
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM ROOM", con);
            DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            Console.Write(dt.ToString());

            con.Close();

            //return dt;
        }
    }
}
