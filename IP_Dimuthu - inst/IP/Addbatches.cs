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
    public partial class Addbatches : Form
    {
        public Addbatches()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbatches_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet2.Degree' table. You can move, or remove it, as needed.
            this.degreeTableAdapter1.Fill(this.resourceAllocationDataSet2.Degree);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet1.Degree' table. You can move, or remove it, as needed.
            this.degreeTableAdapter.Fill(this.resourceAllocationDataSet1.Degree);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drow = (DataRowView)comboBox1.SelectedItem;
            string g_id = drow.Row.ItemArray[0].ToString(); 
            
            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addBatch(textBox2.Text, int.Parse(textBox3.Text),g_id));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
