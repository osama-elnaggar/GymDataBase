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
            this.Hide();
            Form f = new MemberPayments(memberID);
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new LogWorkout(memberID);
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BookCLass(memberID);
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FeedBack(memberID);
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AttendsClass(memberID);
            f.ShowDialog();
            f = null;
            this.Show();
        }
    }
}
