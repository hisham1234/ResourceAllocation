using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class degrees
    {

        private string _name;
        private string _university;
        private string _duration;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string name
        {
            set
            {
                this._name = value;
            }
            get
            {
                return _name;
            }
        }

        public string university
        {
            set
            {
                this._university = value;
            }
            get
            {
                return _university;
            }
        }

        public string duration
        {
            set
            {
                this._duration = value;
            }
            get
            {
                return _duration;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewDegree @name,@university,@duration  ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", _name);
            cmd.Parameters.AddWithValue("@university", _university);
            cmd.Parameters.AddWithValue("@duration", _duration);

             try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Degree Added ";
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