using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IP_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string addLecturer(string nic, string lid, string fname, string lname, string cont_num);

        [OperationContract]
        DataTable viewLecturer();

        [OperationContract]
        string addGrp(string gid, string no, string eno,string sno);

        [OperationContract]
        DataTable viewGroup();

        [OperationContract]
        string addIns(string nic, string id);

        [OperationContract]
        DataTable viewIns();

        [OperationContract]
        DataTable viewLabs(string day, string time, string gid);

        [OperationContract]
        string addPracSession(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, DateTime sdt, DateTime edt);

        [OperationContract]
        void addPracDates(DateTime d1,DateTime d2);

        [OperationContract]
         string addLecSession(string bid, string mid, string lid, string tid, string day, string time, string hid, DateTime d1, DateTime d2);

        [OperationContract]
        void addLecDates(DateTime d1, DateTime d2);

        [OperationContract]
        DataTable viewHalls(string day, string bid, string time);

        [OperationContract]
        DataTable viewLectureSessions();

        [OperationContract]
        DataTable viewLectureSchedule(string bid, string mid);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
