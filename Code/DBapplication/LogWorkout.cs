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
    public partial class LogWorkout : Form
    {
        int MemberID;
        GymMemberController controllerObj;
        public LogWorkout(int ID)
        {
            InitializeComponent();
            controllerObj = new GymMemberController();
            dataGridView1.DataSource = controllerObj.Getworkouts();
            comboBox1.DataSource = controllerObj.GetPlanID();
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            MemberID = ID;
        }

        private void LogWorkout_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y;
            if (int.TryParse(comboBox1.Text, out y) )
            {
                int x = controllerObj.RegisterPlan(y, MemberID, dateTimePicker1.Value);
                if (x == 0)
                {
                    MessageBox.Show("workout already resgistered");
                }
                else
                {
                    MessageBox.Show("register completed");
                }
            }

        }
    }
}
