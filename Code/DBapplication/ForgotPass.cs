using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DBapplication
{
    public partial class ForgotPass : Form
    {
        Controller controllerObj;
        public ForgotPass()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text )
            {
                MessageBox.Show("passwords not matching");
            }
            else
            {
                DataTable check = controllerObj.checkemail(textBox1.Text);
                if (check == null)
                {
                    MessageBox.Show("email doesnt exist");
                }
                else
                {
                    int result = controllerObj.forgotpass(textBox2.Text,textBox1.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("unable to update pass");
                    }else
                    {
                        MessageBox.Show("updated password");
                        Form f = new Welcome();
                        this.Close();
                    }

                }
            }
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }
    }
}
