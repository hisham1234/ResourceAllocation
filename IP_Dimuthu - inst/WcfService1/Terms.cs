using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1
{
    public class Terms
    {
        private string _term_id;
        private string _start_date;
        private string _end_date;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string term_id
        {
            set
            {
                this._term_id = value;
            }
            get
            {
                return _term_id;
            }
        }
        public string start_date
        {
            set
            {
                this._start_date = value;
            }
            get
            {
                return _start_date;
            }
        }

        public string end_date
        {
            set
            {
                this._end_date = value;
            }
            get
            {
                return _end_date;
            }
        }

        public string add()
        {

            string sql = "EXEC AddNewTerm @Term_id,@start_date,@end_date";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Term_id", _term_id);
            cmd.Parameters.AddWithValue("@start_date", _start_date);
            cmd.Parameters.AddWithValue("@end_date", _end_date);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Term Added ";
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