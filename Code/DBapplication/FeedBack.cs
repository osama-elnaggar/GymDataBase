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
    public partial class FeedBack : Form
    {
        GymMemberController controllerObj;
        int MemberID;
        public FeedBack(int ID)
        {
            InitializeComponent();
            controllerObj = new GymMemberController();
            MemberID = ID;

            dataGridView1.DataSource = controllerObj.GetRegisterdWorkouts(MemberID);

            comboBox1.DataSource = controllerObj.GetTrainersID();
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = controllerObj.GetWorkoutTime(MemberID);
            comboBox2.DisplayMember = "Date";
            comboBox2.ValueMember = "Date";

        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime s=Convert.ToDateTime(comboBox2.SelectedValue);
            int x = controllerObj.AddFeedBack(textBox1.Text, s, y, MemberID);
            if(x== 0)
            {
                MessageBox.Show("failed to insert feedback");
            }
            else
            {
                MessageBox.Show("thanks for the feedback");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
