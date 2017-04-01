using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.ServiceReference1;

namespace IP
{
    public partial class AddLectureSessions : Form
    {
        public AddLectureSessions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddLectureSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet12.Lec_halls' table. You can move, or remove it, as needed.
            this.lec_hallsTableAdapter.Fill(this.resourceAllocationDataSet12.Lec_halls);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet11.terms' table. You can move, or remove it, as needed.
            this.termsTableAdapter.Fill(this.resourceAllocationDataSet11.terms);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet10.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.resourceAllocationDataSet10.lecturers);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet9.Modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.resourceAllocationDataSet9.Modules);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet8.Batches' table. You can move, or remove it, as needed.
            this.batchesTableAdapter.Fill(this.resourceAllocationDataSet8.Batches);

        }

        private void button2_Click(object sender, EventArgs e)
        {


            DataRowView bid = (DataRowView)comboBox1.SelectedItem;
            string batch = bid.Row.ItemArray[0].ToString();

            DataRowView mid = (DataRowView)comboBox2.SelectedItem;
            string module = mid.Row.ItemArray[0].ToString();


            DataRowView lid = (DataRowView)comboBox7.SelectedItem;
            string lec = lid.Row.ItemArray[0].ToString();

            DataRowView tid = (DataRowView)comboBox6.SelectedItem;
            string trm = tid.Row.ItemArray[0].ToString();

            string day = comboBox5.SelectedItem.ToString();

            string time = comboBox4.SelectedItem.ToString();

            DataRowView hid = (DataRowView)comboBox3.SelectedItem;
            string hall = hid.Row.ItemArray[0].ToString();

            DateTime d1 = dateTimePicker1.Value.Date;
            DateTime d2 = dateTimePicker2.Value.Date;

            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addLecSession(batch, module, lec, trm, day, time, hall, d1, d2));
            obj.addLecDates(d1,d2);












        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRowView bid = (DataRowView)comboBox1.SelectedItem;
            string batch = bid.Row.ItemArray[0].ToString();
            string day = comboBox5.SelectedItem.ToString();

            string time = comboBox4.SelectedItem.ToString();

            Service1Client obj = new Service1Client();
            dataGridView1.DataSource = obj.viewHalls(day,batch,time);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            dataGridView1.DataSource = obj.viewLectureSessions();
        }
    }
}
