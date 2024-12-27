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
            userID = ID;
            
            //comboBox2.DataSource = controllerObj.GetTrainerID();
            //comboBox2.DisplayMember = "ID";
            //comboBox2.ValueMember = "ID";

          
            DurationComboBox.Items.Add("01:00:00");
            DurationComboBox.Items.Add("02:00:00");
            DurationComboBox.Items.Add("03:00:00");
            DurationComboBox.Items.Add("00:45:00");
            DurationComboBox.Items.Add("00:30:00");
            DurationComboBox.Items.Add("01:30:00");
            DurationComboBox.Items.Add("01:15:00");
            DurationComboBox.SelectedIndex = 0;
            comboBox1.Items.Add("01:00:00");
            comboBox1.Items.Add("02:00:00");
            comboBox1.Items.Add("03:00:00");
            comboBox1.Items.Add("00:45:00");
            comboBox1.Items.Add("00:30:00");
            comboBox1.Items.Add("01:30:00");
            comboBox1.Items.Add("01:15:00");
            comboBox1.SelectedIndex = 0;

            if (x == 2)   // If Trainer He Can not Delete 
            {
                DeleteClass.Enabled = false;
                DeletePlan.Enabled = false;
                ShowClasses.Enabled = false;
                ShowPlans.Enabled = false;
                SearchClass.Enabled = false;
                SearchPlan.Enabled = false;
                //comboBox2.Enabled = false;
               
            }
            else  // Admin
            {
                AddClass.Enabled = false;
                AddPlan.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
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

            try
            {
                int capacity;
                DateTime time;
                int price;
                int result = -1;
                TimeSpan duration;
                if (TimeSpan.TryParse(DurationComboBox.SelectedItem.ToString(), out duration))
                { }
                if (int.TryParse(textBox2.Text, out capacity) && int.TryParse(textBox5.Text, out price))
                {
                    //time= Convert.ToDateTime(DurationComboBox.SelectedItem.ToString());
                    //int userID = Convert.ToInt32(comboBox1.SelectedValue);
                    //int userID = 0;
                    result = controllerObj.AddClass(textBox1.Text, capacity, duration, textBox4.Text, userID, price);
                }
                if (result == 0 || result == -1)
                {
                    MessageBox.Show("couldnt add class");
                }
                else
                {
                    MessageBox.Show("Sucessfully Added Class");
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("Error Happened Make sure You entered Correct values...");
            }
            
        }

        private void ShowClasses_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = controllerObj.ShowAllClasses();
            dataGridView1.Refresh();
        }

        private void ShowPlans_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource=controllerObj.ShowAllPlans();
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                int result = controllerObj.DeleteClass(Int16.Parse(textBox10.Text));
                if (result == 0)
                {
                    MessageBox.Show("couldnt delete class");
                }
                else
                {
                    MessageBox.Show("class deleted sucessfully");
                    dataGridView1.Refresh();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error Happened Make sure You entered Correct values...");
            }
        }


        private void DeletePlan_Click(object sender, EventArgs e)
        {
            try {
                int result = controllerObj.DeletePlan(Int16.Parse(textBox11.Text));
                if (result == 0)
                {
                    MessageBox.Show("couldnt delete plan, Some one is Registered to It OR Wrong ID");
                }
                else
                {
                    MessageBox.Show("plan deleted sucessfully");
                    dataGridView1.Refresh();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error Happened Make sure You entered Correct values...");
            }
        }

        

        private void SearchClass_Click(object sender, EventArgs e)
        {
            string s = SearchClassBox.Text;
            dataGridView1.DataSource = controllerObj.SearchClassByName(s);
            dataGridView1.Refresh();
        }

        private void SearchPlan_Click(object sender, EventArgs e)
        {
            string s = SearchPlanBox.Text;
            dataGridView1.DataSource = controllerObj.SearchPlanByGoals(s);
            dataGridView1.Refresh();
        }

        private void AddPlan_Click(object sender, EventArgs e)
        {
            try
            {
                int result = -1;
                TimeSpan duration;
                if (TimeSpan.TryParse(comboBox1.SelectedItem.ToString(), out duration))
                { }
                int price;
               
                    if (int.TryParse(textBox9.Text, out price))
                        result = controllerObj.AddPlan(textBox6.Text, textBox7.Text, duration, userID, price);
                    if (result == 0 || result == -1)
                    {
                        MessageBox.Show("couldnt add plan");
                    }
                    else
                    {
                        MessageBox.Show("plan added succefully");
                    }
               
            }
            catch(Exception E)
            {
                MessageBox.Show("Error Happened, Enter Data Correct!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.GetallclassesByID(userID);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerObj.GetallPlansByID(userID);
            dataGridView1.Refresh();
        }
    }
}
