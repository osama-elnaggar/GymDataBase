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
    public partial class AddMember : Form
    {
        Controller controllerObj;
        public AddMember()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text.Length == 11)
            {
                try
                {
                    int result = controllerObj.AddGymMember(textBox1.Text,
                    textBox2.Text, comboBox1.SelectedItem.ToString(), PhoneTextbox.Text, textBox3.Text, textBox4.Text, "Null", dateTimePicker1.Value.Date, null);

                    if (result == 0)
                        MessageBox.Show("The insertion failed wrong data or row duplication happened...");
                    else
                    {
                        MessageBox.Show("The Member is Added successfully!");
                        DataTable D = controllerObj.ShowMember(textBox3.Text, textBox4.Text);
                        dataGridView1.DataSource = D;
                        dataGridView1.Refresh();

                    }
                }
                catch (Exception E)
                { MessageBox.Show("Wrong Data Inserted..."); }
            }
            else
            {
                MessageBox.Show("Invalid Phone Number...");
            }
        }

    }
}

