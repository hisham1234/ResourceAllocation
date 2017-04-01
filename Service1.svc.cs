using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace IP_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string addLecturer(string nic, string lid, string fname, string lname, string cont_num)
        {
            Lecturer lec = new Lecturer();
            lec._nic = nic;
            lec._fname = fname;
            lec._lname = lname;
            lec._cont_number = cont_num;
            lec._lid = lid;

            return lec.addLec();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public DataTable viewLecturer()
        {
            Lecturer lec = new Lecturer();
            return lec.viewLec();

        }

        public string addGrp(string gid,string no,string sno,string eno)
        {
            Groups grp = new Groups();
            grp._grpId = gid;
            grp._startNo = sno;
            grp._endNo = eno;
            grp._no = int.Parse(no);

           return grp.addGrp();
        }
        public DataTable viewGroup()
        {
            Groups gp = new Groups();
            return gp.viewGroup();
        }

        public string addIns(string nic,string id)
        {
            Instructors ins = new Instructors();
            ins._nic = nic;
            ins._instr_id = id;
            return ins.add();
        }
        public DataTable viewIns()
        {
            Instructors ins = new Instructors();
           return  ins.viewLec();
        }

        public DataTable  viewLabs(string day,string time,string gid)
        {
            PracSession pr = new PracSession();
            pr._day = day;
            pr._time = time;
            pr._gid = gid;

            return pr.viewLabs();
        }

        public string addPracSession(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, DateTime sdt, DateTime edt)
        {
            PracSession pr = new PracSession();
            pr._mid = mid;
            pr._day = day;
            pr._time = time;
            pr._bid = bid;
            pr._tid = trm;
            pr._lid = lid;
            pr._ins = ins;
            pr._d1 = sdt;
            pr._d2 = edt;
            pr._gid = grp;
           return pr.addPracSession();

        }
        public void addPracDates(DateTime d1,DateTime d2)
        {
            PracSession pr = new PracSession();
            pr._d1 = d1;
            pr._d2 = d2;
            pr.addPracDates();
        }
        public void addLecDates(DateTime d1, DateTime d2)
        {
            LectureSessions lc = new LectureSessions();
            lc._d1 = d1;
            lc._d2 = d2;
            lc.addLecDates();
        }

        public string addLecSession(string bid, string mid, string lid, string tid, string day, string time, string hid, DateTime d1, DateTime d2)
        {
            LectureSessions lc = new LectureSessions();
            lc._batch = bid;
            lc._module = mid;
            lc._lec = lid;
            lc._trm = tid;
            lc._day = day;
            lc._time = time;
            lc._hall = hid;
            lc._d1 = d1;
            lc._d2 = d2;
           return  lc.addLecSession();
        }


        public DataTable viewHalls(string day,string bid,string time)
        {
            LectureSessions pc = new LectureSessions();
            pc._day = day;
            pc._batch = bid;
            pc._time = time;
           return  pc.viewHalls();
        }
        public DataTable viewLectureSessions()
        {
            LectureSessions lc = new LectureSessions();
           return lc.viewLectureSessions();
        }

        public DataTable viewLectureSchedule(string bid,string mid)
        {
            LectureSessions ls = new LectureSessions();
            ls._batch = bid;
            ls._module = mid;

            return ls.viewLectureSchedule();

        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
