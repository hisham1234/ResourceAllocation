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
    public partial class AddLabs : Form
    {
        public AddLabs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addLabs(textBox2.Text, int.Parse(textBox3.Text), comboBox1.SelectedItem.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
