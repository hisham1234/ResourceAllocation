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
    public partial class ViewLecturers : Form
    {
        public ViewLecturers()
        {
            InitializeComponent();
            Service1Client obj = new Service1Client();
            dataGridView1.DataSource = obj.viewLecturers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLecturers_Load(object sender, EventArgs e)
        {

        }
    }
}
