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
    public partial class AdminPanelEntry : Form
    {
        public AdminPanelEntry()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select Record Type","Record Type Not Selected",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(this.comboBox1.SelectedIndex==0)
            {
                AddNewLecturers obj = new AddNewLecturers();
                obj.Visible = true;
            }
            else if(this.comboBox1.SelectedIndex==1)
            {
                AddInstructor obj = new AddInstructor();
                obj.Visible = true;
            }
            else if(this.comboBox1.SelectedIndex==2)
            {
                AddGroups obj = new AddGroups();
                obj.Visible = true;
            }
            else if(this.comboBox1.SelectedIndex==3)
            {
                //AddPracticalSessions obj = new AddPracticalSessions();
                //obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                AddLabs obj = new AddLabs();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                AddDegrees obj = new AddDegrees();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 6)
            {
                Addbatches obj = new Addbatches();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 7)
            {
                AddTerms obj = new AddTerms();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 8)
            {
                //AddPracticalSessions obj = new AddPracticalSessions();
                //obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 9)
            {
                AddNotices obj = new AddNotices();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 10)
            {
                AddModule obj = new AddModule();
                obj.Visible = true;
            }
            else if (this.comboBox1.SelectedIndex == 11)
            {
                AddLectureHalls obj = new AddLectureHalls();
                obj.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Record Type", "Record Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (this.comboBox1.SelectedIndex == 0)
            {
                ViewLecturers obj = new ViewLecturers();
                obj.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
