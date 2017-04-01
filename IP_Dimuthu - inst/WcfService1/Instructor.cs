using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1
{
    public class Instructor
    {
        private string _nic;
        private string _ins_id;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string nic
        {
            set
            {
                this._nic = value;
            }
            get
            {
                return _nic;
            }
        }
        public string ins_id
        {
            set
            {
                this._ins_id = value;
            }
            get
            {
                return _ins_id;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewInstructor @nic,@ins_id ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nic", _nic);
            cmd.Parameters.AddWithValue("@ins_id", _ins_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Instructor Added ";
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