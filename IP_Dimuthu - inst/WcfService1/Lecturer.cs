using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1
{
    public class Lecturer
    {
        private string _nic;
        private string _fname;
        private string _lname;
        private string _lec_id;


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
        public string fname
        {
            set
            {
                this._fname = value;
            }
            get
            {
                return _fname;
            }
        }
        public string lname
        {
            set
            {
                this._lname = value;
            }
            get
            {
                return _lname;
            }
        }
        public string lec_id
        {
            set
            {
                this._lec_id = value;
            }
            get
            {
                return _lec_id;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewLecturer @nic,@fname,@lname,@lec_id";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nic", _nic);
            cmd.Parameters.AddWithValue("@fname", _fname);
            cmd.Parameters.AddWithValue("@lname", _lname);
            cmd.Parameters.AddWithValue("@lec_id", _lec_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Lecturer Added ";
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



        public DataTable view()
        {

            string sl="select * from lecturers";

            SqlCommand cmd = new SqlCommand(sl, con);

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            adp.Fill(dt);
            dt.TableName = "lecturers";
            return dt;
            con.Close();
        }
    }
}