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
    public partial class PlansandClassesForm : Form
    {
        PlansAndClassController controllerObj;
        int userID;
        int usernum;
        public PlansandClassesForm(int x,int ID)
        {
            InitializeComponent();
            controllerObj = new PlansAndClassController();
            usernum = x;
            comboBox1.DataSource = controllerObj.GetClassNames();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";

            comboBox3.DataSource = controllerObj.GetPlanGoals();
            comboBox3.DisplayMember = "Goals";
            comboBox3.ValueMember = "Goals";

            comboBox2.DataSource = controllerObj.GetTrainerID();
            comboBox2.DisplayMember = "ID";
            comboBox2.ValueMember = "ID";


            userID = ID;
            if (x == 2)   // If Trainer He Can not Delete 
            {
                DeleteClass.Enabled = false;
                DeletePlan.Enabled = false;
                comboBox2.Enabled = false;
                label10.Enabled = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PlansandClassesForm_Load(object sender, EventArgs e)
        {

        }

        private void AddClass_Click(object sender, EventArgs e)
        {
            int capacity;
            DateTime time;
            int price;
            int result=-1;
            if(int.TryParse(textBox2.Text, out capacity) && int.TryParse(textBox5.Text, out price))
            {
                time= Convert.ToDateTime(textBox3.Text);
                //int userID = Convert.ToInt32(comboBox1.SelectedValue);
                result =controllerObj.AddClass(textBox1.Text, capacity, time , textBox4.Text, userID, price);
            }
            if(result == 0 || result == -1)
            {
                MessageBox.Show("couldnt add class");
            }
            else
            {
                MessageBox.Show("sucessfully added class");
            }
            
        }

        private void ShowClasses_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = controllerObj.ShowAllClasses();
        }

        private void ShowPlans_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource=controllerObj.ShowAllPlans();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteClass_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(textBox10.Text,out x))
            {
            int result = controllerObj.DeleteClass(x);
                if(result == 0)
                {
                    MessageBox.Show("couldnt delete class");
                }
                else
                {
                    MessageBox.Show("class deleted sucessfully");
                }
            }

        }

        private void DeletePlan_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(textBox11.Text, out x))
            {
                int result = controllerObj.DeletePlan(x);
                if (result == 0)
                {
                    MessageBox.Show("couldnt delete plan");
                }
                else
                {
                    MessageBox.Show("plan deleted sucessfully");
                }
            }

        }

        private void SearchClass_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(comboBox1.SelectedValue);
            dataGridView1.Refresh();
            dataGridView1.DataSource = controllerObj.SearchClassByName(s);
        }

        private void SearchPlan_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(comboBox3.SelectedValue);
            dataGridView1.Refresh();
            dataGridView1.DataSource = controllerObj.SearchPlanByGoals(s);
        }

        private void AddPlan_Click(object sender, EventArgs e)
        {
            int result = -1;
            DateTime time =Convert.ToDateTime(textBox8.Text); ;
            int price;
            if (usernum == 2) //trainer
            {
                if (int.TryParse(textBox9.Text,out price))
                result = controllerObj.AddPlan(textBox6.Text, textBox7.Text, time, userID, price);
                if (result == 0 || result == -1)
                {
                    MessageBox.Show("couldnt add plan");
                }
                else
                {
                    MessageBox.Show("plan added succefully");
                }
            }
            else //admin
            {
                int inserted= Convert.ToInt32(comboBox2.SelectedValue);
                if (int.TryParse(textBox9.Text, out price))
                    result = controllerObj.AddPlan(textBox6.Text, textBox7.Text, time, inserted, price);
                if (result == 0 || result == -1)
                {
                    MessageBox.Show("couldnt add plan");
                }
                else
                {
                    MessageBox.Show("plan added succefully");
                }
            }
        }
    }
}
