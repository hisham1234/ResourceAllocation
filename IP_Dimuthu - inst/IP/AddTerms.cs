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
    public partial class AddTerms : Form
    {
        public AddTerms()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddTerms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addTerm(textBox2.Text, dateTimePicker1.Value.ToString().Substring(0, 10), dateTimePicker2.Value.ToString().Substring(0, 10)));
        }
    }
}
