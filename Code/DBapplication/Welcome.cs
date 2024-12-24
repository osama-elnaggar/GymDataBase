using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Welcome : Form
    {
        Controller controllerObj;
        public Welcome()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }
        static string Encrypt(string text)
        {
            string cipherText = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC + 4 - 'a') % 26) + 'a');
                    cipherText += shifted;
                }
                else
                {
                    cipherText += c;
                }

            }
            return cipherText;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new SignUp(this);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new GymTrainerSignup(this);
            f .Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable t = controllerObj.CheckCreedentials(textBox1.Text,Encrypt(textBox2.Text));
            if (t == null)
            {
                MessageBox.Show("invalid username or password");
            }
            else
            {
                MessageBox.Show("login succssecful");
                Form f = new GymMember(this);
                f.Show();
                this.Hide();
            }
        }
    }
}
