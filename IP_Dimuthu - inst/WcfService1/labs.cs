using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WcfService1
{
    public class labs
    {
        private string _lab_id;
        private int _capacity;
        private string _status;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string lab_id
        {
            set
            {
                this._lab_id = value;
            }
            get
            {
                return _lab_id;
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
            string sql = "EXEC AddNewLabs @lab_id,@capacity,@status";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@lab_id", _lab_id);
            cmd.Parameters.AddWithValue("@capacity", _capacity);
            cmd.Parameters.AddWithValue("@status", _status);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Lab Added ";
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