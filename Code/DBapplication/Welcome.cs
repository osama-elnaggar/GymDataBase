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
            this.Hide();
            Form f = new SignUp(this);
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new GymTrainerSignup(this);
            f.ShowDialog();
            f = null;
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable t = controllerObj.CheckCreedentials(textBox1.Text, textBox2.Text);
            if (t == null)
            {
                MessageBox.Show("invalid username or password");
            }
            else
            {
                this.Hide();
                MessageBox.Show("login succssecful");
                Form f = new GymMember(controllerObj.getID(textBox1.Text, textBox2.Text));
                f.ShowDialog();
                f = null;
                this.Show();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void UserLogin_Click_1(object sender, EventArgs e)
        {

            DataTable t = controllerObj.CheckCreedentialsForUser(UserEmailBox.Text, UserPassBox.Text);
            if (t == null)
            {
                MessageBox.Show("invalid username or password");
            }
            else
            { 
                MessageBox.Show("login succssecful");
                string Role = controllerObj.GetUserRole(UserEmailBox.Text, UserPassBox.Text);
                int id = controllerObj.getIDForUser(UserEmailBox.Text, UserPassBox.Text);
                if (Role == "Trainer")
                {
                    this.Hide();
                    Form f = new User(2, id);
                    f.ShowDialog();
                    f = null;
                    this.Show();
                }
                else if (Role == "Admin")
                {
                    this.Hide();
                    Form f = new User(1, id);
                    f.ShowDialog();
                    f = null;
                    this.Show();
                }
                else if (Role == "Worker")
                {
                    this.Hide();
                    Form f = new User(3, id);
                    f.ShowDialog();
                    f = null;
                    this.Show();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ForgotPass();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new ForgotPassUser();
            f.ShowDialog();
            f = null;
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

