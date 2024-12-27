using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
  

    public partial class DeleteMember : Form
    {
        Controller controllerObj;
        public DeleteMember()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = controllerObj.DeleteGymMember(Int16.Parse(textBox1.Text));

                if (result == 0)
                    MessageBox.Show("No Deletion Happened May Be ID Wrong and doesnot exist...");
                else
                    MessageBox.Show("Member Deleted Successfully!");
            }
            catch (Exception E)
            { MessageBox.Show("Wrong Data Inserted..."); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.SearchmemberByname(textBox2.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception E)
            {
                MessageBox.Show("Wrong Data Inserted...");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = controllerObj.ShowAllMembers();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception E)
            {
                MessageBox.Show("Some Errors Happened");
            }


        }
    }
    }

