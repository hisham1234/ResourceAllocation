using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IP_WcfService
{
    public class LectureSessions
    {

        private string batch;
        private string module;
        private string lec;
        private string trm;
        private string day;
        private string time;
        private string hall;
        private DateTime d1;
        private DateTime d2;

        public string _batch
        {
            set
            {
                this.batch = value;
            }
            get
            {
                return batch;
            }
        }

        public string _module
        {
            set
            {
                this.module = value;
            }
            get
            {
                return module;
            }
        }

        public string _lec
        {
            set
            {
                this.lec = value;
            }
            get
            {
                return lec;
            }
        }


        public string _trm
        {
            set
            {
                this.trm = value;
            }
            get
            {
                return trm;
            }
        }


        public string _day
        {
            set
            {
                this.day = value;
            }
            get
            {
                return day;
            }
        }

        public string _time
        {
            set
            {
                this.time = value;
            }
            get
            {
                return time;
            }
        }
        public string _hall
        {
            set
            {
                this.hall = value;
            }
            get
            {
                return hall;
            }
        }

        public DateTime _d1
        {
            set
            {
                this.d1 = value;
            }
            get
            {
                return d1;
            }
        }
        public DateTime _d2
        {
            set
            {
                this.d2 = value;
            }
            get
            {
                return d2;
            }
        }


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());


        public string addLecSession()
        {
            SqlCommand cmd = new SqlCommand("exec instLecs @bid,@mid,@lid,@tid,@day,@time,@hid,@d1,@d2", con);
            cmd.Parameters.AddWithValue("@bid", _batch);
            cmd.Parameters.AddWithValue("@mid", _module);
            cmd.Parameters.AddWithValue("@lid", _lec);
            cmd.Parameters.AddWithValue("@tid", _trm);
            cmd.Parameters.AddWithValue("@day", _day);
            cmd.Parameters.AddWithValue("@time", _time);
            cmd.Parameters.AddWithValue("@hid", _hall);
            cmd.Parameters.AddWithValue("@d1", _d1);
            cmd.Parameters.AddWithValue("@d2", _d2);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "Lecture session added";
            }
            catch (SqlException ex)
            {
                return ex.Message;

            }

        }
        public void addLecDates()
        {
            SqlCommand cmdlid = new SqlCommand("exec get_lcid", con);
            con.Open();
            int l_id = Convert.ToInt32(cmdlid.ExecuteScalar());
            con.Close();


            SqlCommand cmdldt = new SqlCommand("insert into lecture_dates values (@lid,@date)", con);


            List<object> ls = new List<object>();


            int i = 0;
            while (d1 <= d2)
            {


                ls.Add(d1.ToString().Substring(0, 9));
                d1 = d1.AddDays(7);

                cmdldt.Parameters.AddWithValue("@lid", l_id);
                cmdldt.Parameters.AddWithValue("@date", ls[i].ToString());


                con.Open();
                cmdldt.ExecuteNonQuery();
                con.Close();


                cmdldt.Parameters.Clear();
                i++;








            }







        }
        public DataTable viewHalls()
        {
            SqlCommand cmd = new SqlCommand("exec viewHalls @day,@time,@bid", con);
            cmd.Parameters.AddWithValue("@day", _day);
            cmd.Parameters.AddWithValue("@time", _time);
            cmd.Parameters.AddWithValue("@bid", _batch);

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dt.TableName = "availableHalls";
            return dt;
        }
        public DataTable viewLectureSessions()
        {
            SqlCommand cmd = new SqlCommand("exec viewLectureSessions", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dt.TableName = "lecture sessions";

            return dt;
        }
        public DataTable viewLectureSchedule()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("exec viewLecSchedule @batch,@mid", con);
            cmd.Parameters.AddWithValue("@batch",_batch);
            cmd.Parameters.AddWithValue("@mid",_module );

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dt.TableName = "lectureSchedule";

            return dt;

        }


    }
}