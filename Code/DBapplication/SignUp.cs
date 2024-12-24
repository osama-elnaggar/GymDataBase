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
        GymMemberController controllerObj;
        public SignUp(Welcome f)
        {
            InitializeComponent();
            controllerObj = new GymMemberController();
        }

        static string Encrypt(string text)
        {
            string cipherText = "";
            foreach(char c in text)
            {
                if(char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC + 4 - 'a') % 26) + 'a');
                    cipherText += shifted;
                }else
                {
                    cipherText += c;
                }

            }
            return cipherText;

        }

        static string Decrypt(string text)
        {
            string cipherText = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC - 4 - 'a') % 26) + 'a');
                    cipherText += shifted;
                }
                else
                {
                    cipherText += c;
                }

            }
            return cipherText;
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
            string password = Encrypt(textBox3.Text);
            string decrpted = Decrypt(password);

            if (textBox2.Text == "" || textBox3.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("invalid input");
            }
            else
            {

                int completed = controllerObj.GymMemberSignup( textBox2.Text, password, dateTimePicker1.Value, comboBox1.SelectedText, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
                    if (completed == 0)
                    {
                        MessageBox.Show("failed insertion");
                    }
                    else
                    {
                        MessageBox.Show("sign up succesful!");
                        textBox2.Clear();
                        textBox3.Clear();
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
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
