using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace WcfService1
{
    public class Notices
    {
        private string _val_date;
        private string _msg;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string val_date
        {
            set
            {
                this._val_date = value;
            }
            get
            {
                return _val_date;
            }
        }

        public string msg
        {
            set
            {
                this._msg = value;
            }
            get
            {
                return _msg;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewNotice @valid_date,@description";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@valid_date", _val_date);
            cmd.Parameters.AddWithValue("@description", _msg);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Notice Added ";
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