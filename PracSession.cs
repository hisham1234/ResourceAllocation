using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IP_WcfService
{


    public class PracSession
    {
        private string day;
        private string time;
        private string gid;
        private string mid;
        private DateTime d1;
        private DateTime d2;
        private string ins;

        private string bid;
        private string lid;
        private string tid;


        public string _tid
        {
            set
            {
                this.tid = value;
            }
            get
            {
                return tid;
            }
        }

        public string _bid
        {
            set
            {
                this.bid = value;
            }
            get
            {
                return bid;
            }
        }


        public string _lid
        {
            set
            {
                this.lid = value;
            }
            get
            {
                return lid;
            }
        }


        public string _ins
        {
            set
            {
                this.ins = value;
            }
            get
            {
                return ins;
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


        public string _mid
        {
            set
            {
                this.mid = value;
            }
            get
            {
                return mid;
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


        public string _gid
        {
            set
            {
                this.gid = value;
            }
            get
            {
                return gid;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public DataTable viewLabs()
        {
            DataTable dt = new DataTable();
            string vwlbs = "exec viewLabs @day,@time,@gid";


            SqlCommand cmd = new SqlCommand(vwlbs, con);
            con.Open();

            cmd.Parameters.AddWithValue("@day", _day);
            cmd.Parameters.AddWithValue("@time", _time);
            cmd.Parameters.AddWithValue("@gid", _gid);

            cmd.Parameters.AddWithValue("@d", 2);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            con.Close();
            adp.Fill(dt);

            dt.TableName = "Practical_Sessions";
            return dt;
        }

        public string addPracSession()
        {
            SqlCommand cmd = new SqlCommand("exec inst @mid,@day,@time,@bid,@trm,@grp,@lid,@ins,@sdt,@edt", con);
            cmd.Parameters.AddWithValue("@mid", mid);

            cmd.Parameters.AddWithValue("@day", day);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@trm", tid);
            cmd.Parameters.AddWithValue("@grp", gid);
            cmd.Parameters.AddWithValue("@lid", lid);
            cmd.Parameters.AddWithValue("@ins", ins);
            cmd.Parameters.AddWithValue("@sdt", d1);

            cmd.Parameters.AddWithValue("@edt", d2);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "practical session added";
            }

            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public void addPracDates()
        {
            SqlCommand cmdpid = new SqlCommand("exec get_prid", con);
            con.Open();
            int pr_id = Convert.ToInt32(cmdpid.ExecuteScalar());
            con.Close();


            SqlCommand cmdpdt = new SqlCommand("insert into prac_dates values (@pid,@date)", con);


            List<object> ls = new List<object>();


            int i = 0;
            while (d1 <= d2)
            {

                
                ls.Add(d1.ToString().Substring(0, 9));
                d1 = d1.AddDays(7);

                cmdpdt.Parameters.AddWithValue("@pid", pr_id);
                cmdpdt.Parameters.AddWithValue("@date", ls[i].ToString());


                con.Open();
                cmdpdt.ExecuteNonQuery();



                con.Close();






                cmdpdt.Parameters.Clear();
                i++;


            }
        }

    
    }
}