using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
namespace WcfService1
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
        string addBatch(string b_name, int n_o_s, string d_id);

        [OperationContract]
        string addDegree(string d_name, string uni, string duration);

        [OperationContract]
        string addGroup(string g_name,int n_of_students,string s_number,string e_number);

        [OperationContract]
        string addLabs(string lab_id, int capacity, string status);

        [OperationContract]
        string addLectureHalls(string hall_id, int capacity, string status);

        [OperationContract]
        string addLecurer(string nic, string fname, string lname, string lec_id);

        [OperationContract]
        string addModule(string m_id,string m_name,string lec_id);

        [OperationContract]
        string addNotice(string val_date, string msg);

        [OperationContract]
        string addInstructor(string nic, string ins_id);

        [OperationContract]
        string addTerm(string t_id, string start_date, string end_date);

        [OperationContract]
        DataTable viewLecturers();

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
