using IP.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP
{
    public partial class AddModule : Form
    {
        public AddModule()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet3.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter1.Fill(this.resourceAllocationDataSet3.lecturers);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet.lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.resourceAllocationDataSet.lecturers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drow =(DataRowView)comboBox1.SelectedItem;
            string g_id= drow.Row.ItemArray[0].ToString();

            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addModule(textBox2.Text, textBox3.Text, g_id));
        }
    }
}
