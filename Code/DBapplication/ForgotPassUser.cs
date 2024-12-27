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
    public partial class ForgotPassUser : Form
    {
        Controller controllerObj;
        public ForgotPassUser()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ForgotPassUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("passwords not matching");
            }
            else
            {
                DataTable check = controllerObj.checkemailUser(textBox1.Text);
                if (check == null)
                {
                    MessageBox.Show("email doesnt exist");
                }
                else
                {
                    int result = controllerObj.forgotpassUser(textBox2.Text, textBox1.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("unable to update pass");
                    }
                    else
                    {
                        MessageBox.Show("updated password");
                        Form f = new Welcome();
                        this.Close();
                    }

                }
            }
        }
    }
}
