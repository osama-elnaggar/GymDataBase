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
    public partial class BookCLass : Form
    {
        int MemberID;
        GymMemberController controllerObj;
        public BookCLass(int ID)
        {
            MemberID = ID;
            InitializeComponent();
            controllerObj = new GymMemberController();
            dataGridView1.DataSource= controllerObj.GetClasses();

            comboBox1.DataSource= controllerObj.GetClassID();
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
        }

        private void BookCLass_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.SelectedValue);

            int y = controllerObj.BookClass(MemberID, x, System.DateTime.Now);
            if (y == 0)
            {
                MessageBox.Show("Class Already Booked");
            }
            else
            {
                MessageBox.Show("class booked successfully");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
