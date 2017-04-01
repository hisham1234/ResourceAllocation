using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace WcfService1
{
    public class groups
    {
        private string _group_name;
        private int _number_of_students;
        private string _starting_number;
        private string _ending_number;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string group_name
        {
            set
            {
                this._group_name = value;
            }
            get
            {
                return _group_name;
            }
        }
        public int number_of_students
        {
            set
            {
                this._number_of_students = value;
            }
            get
            {
                return _number_of_students;
            }
        }

        public string starting_number
        {
            set
            {
                this._starting_number = value;
            }
            get
            {
                return _starting_number;
            }
        }

        public string ending_number
        {
            set
            {
                this._ending_number = value;
            }
            get
            {
                return _ending_number;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewGroup @grp_name,@no_of_students,@starting_number,@ending_number";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@grp_name", _group_name);
            cmd.Parameters.AddWithValue("@no_of_students", _number_of_students);
            cmd.Parameters.AddWithValue("@starting_number",_starting_number);
            cmd.Parameters.AddWithValue("@ending_number", _ending_number);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Group Added ";
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