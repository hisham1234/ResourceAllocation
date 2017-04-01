using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1
{
    public class batches
    {
        private string _batch_Name;
        private int _no_of_students;
        private string _degree_id;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string batch_name
        {
            set
            {
                this._batch_Name = value;
            }
            get
            {
                return _batch_Name;
            }
        }
        public int no_of_Students
        {
            set
            {
                this._no_of_students = value;
            }
            get
            {
                return _no_of_students;
            }
        }

        public string degree_id
        {
            set
            {
                this._degree_id = value;
            }
            get
            {
                return _degree_id;
            }
        }

        public string add()
        {
            string sql = "EXEC AddNewBatch @b_name,@no_of_students,@degree";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@b_name", _batch_Name);
            cmd.Parameters.AddWithValue("@no_of_students", _no_of_students);

           
            cmd.Parameters.AddWithValue("@degree", _degree_id);

             try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Batch Added ";
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