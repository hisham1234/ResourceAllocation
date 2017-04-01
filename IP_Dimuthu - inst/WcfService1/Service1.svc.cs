using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public DataTable viewLecturers()
        {
            Lecturer lc = new Lecturer();
            return lc.view();
        }

        public string addBatch(string b_name, int n_o_s,string d_id)
        {
            batches obj = new batches();
            obj.batch_name = b_name;
            obj.no_of_Students = n_o_s;
            obj.degree_id = d_id;
            return obj.add();
        }

        public string addDegree(string d_name, string uni, string duration)
        {
            degrees obj = new degrees();
            obj.name = d_name;
            obj.university = uni;
            obj.duration = duration;
            return obj.add();
        }

        public string addGroup(string g_name, int n_of_students, string s_number, string e_number)
        {
            groups obj = new groups();
            obj.group_name = g_name;
            obj.number_of_students = n_of_students;
            obj.starting_number = s_number;
            obj.ending_number = e_number;
            return obj.add();
        }

        public string addLabs(string lab_id, int capacity, string status)
        {
            labs obj = new labs();
            obj.lab_id = lab_id;
            obj.capacity = capacity;
            obj.status = status;
            return obj.add();
        }

        public string addLectureHalls(string hall_id, int capacity, string status)
        {
            LectureHalls obj = new LectureHalls();
            obj.hall_id = hall_id;
            obj.capacity = capacity;
            obj.status = status;
            return obj.add();

        }

        public string addLecurer(string nic, string fname, string lname, string lec_id)
        {
            Lecturer obj = new Lecturer();
            obj.nic = nic;
            obj.fname = fname;
            obj.lname = lname;
            obj.lec_id = lec_id;
            return obj.add();
        }

        public string addModule(string m_id,string m_name,string lec_id)
        {
            Module obj = new Module();
            obj.module_id = m_id;
            obj.module_name = m_name;
            obj.Lec_id = lec_id;

            return obj.add();
        }

        public string addNotice(string val_date, string msg)
        {
            Notices obj = new Notices();
            obj.val_date = val_date;
            obj.msg = msg;
            return obj.add();
        }

        public string addInstructor(string nic, string ins_id)
        {
            Instructor obj = new Instructor();
            obj.nic = nic;
            obj.ins_id = ins_id;
            return obj.add();

        }

        public string addTerm(string t_id, string start_date, string end_date)
        {
            Terms obj = new Terms();
            obj.term_id = t_id;
            obj.start_date = start_date;
            obj.end_date = end_date;

            return obj.add();
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
