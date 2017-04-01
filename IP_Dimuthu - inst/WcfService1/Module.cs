using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WcfService1
{
    public class Module
    {
        private string _module_id;
        private string _module_name;
        private string _lec_id;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString());

        public string module_id
        {
            set
            {
                this._module_id = value;
            }
            get
            {
                return _module_id;
            }
        }
        public string module_name
        {
            set
            {
                this._module_name = value;
            }
            get
            {
                return _module_name;
            }
        }
        public string Lec_id
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
            string sql = "EXEC AddNewModule @module_id,@module_name,@lec_id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@module_id", _module_id);
            cmd.Parameters.AddWithValue("@module_name",_module_name);
            cmd.Parameters.AddWithValue("@lec_id",_lec_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "New Module Added ";
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