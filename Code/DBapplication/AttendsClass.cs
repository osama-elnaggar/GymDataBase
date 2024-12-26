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
    public partial class AttendsClass : Form
    {
        int memberID;
        GymMemberController controllerObj;
        public AttendsClass(int ID)
        {
            InitializeComponent();
            memberID = ID;
            controllerObj = new GymMemberController();
            dataGridView1.DataSource = controllerObj.GetAttends(memberID);

            comboBox1.DataSource=controllerObj.GetAttendID(memberID);
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }

        private void AttendsClass_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(comboBox1.SelectedValue);
            int x;
            if (radioButton1.Checked)
            {
               x = controllerObj.Attends(memberID, y,System.DateTime.Now);
            }
            else
            {
                x = controllerObj.Attends(memberID, y, dateTimePicker1.Value);

            }
            if(x == 0)
            {
                MessageBox.Show("couldnt attend class");

            }
            else
            {
                MessageBox.Show("class attended sucessfully");
            }


        }
    }
}
