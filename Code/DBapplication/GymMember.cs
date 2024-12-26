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
    public partial class GymMember : Form
    {
        int memberID;
        public GymMember(int ID)
        {
            InitializeComponent();
            memberID = ID;
        }

        private void GymMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new MemberPayments(memberID);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new LogWorkout(memberID);
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form f = new GymTrainerSignup();
            //f.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
