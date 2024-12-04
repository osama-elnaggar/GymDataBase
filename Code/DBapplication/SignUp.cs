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
    public partial class SignUp : Form
    {
        Controller controllerObj;
        public SignUp(Welcome f)
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("invalid input");
            }
            else
            {

                if (int.TryParse(textBox1.Text, out int x))
                {
                int completed = controllerObj.GymMemberSignup(x, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.SelectedText, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                    if (completed == 0)
                    {
                        MessageBox.Show("failed insertion");
                    }
                    else
                    {
                        MessageBox.Show("sign up succesful!");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                        Form f = new Welcome();
                        f.Show();
                        this.Close();
                    }
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
