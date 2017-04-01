using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class LectureHalls
    {
        private string _hall_id;
        private int _capacity;
        private string _status;


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string hall_id
        {
            set
            {
                this._hall_id = value;
            }
            get
            {
                return _hall_id;
            }
        }

        public int capacity
        {
            set
            {
                this._capacity = value;
            }
            get
            {
                return _capacity;
            }
        }

        public string status
        {
            set
            {
                this._status = value;
            }
            get
            {
                return _status;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewLectureHall @hall_id,@capacity,@status";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@hall_id", _hall_id);
            cmd.Parameters.AddWithValue("@capacity", _capacity);
            cmd.Parameters.AddWithValue("@status", _status);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Lecture Hall Added ";
            }

            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();

            }
        }

    }
}