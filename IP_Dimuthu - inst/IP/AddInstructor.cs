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
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddInstructor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet4.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.resourceAllocationDataSet4.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drow = (DataRowView)comboBox1.SelectedItem;
            string g_id = drow.Row.ItemArray[0].ToString(); 

            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addInstructor(g_id, textBox9.Text));
        }
    }
}
