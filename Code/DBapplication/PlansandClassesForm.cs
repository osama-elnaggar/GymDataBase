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
        Controller controllerObj;
        public PlansandClassesForm(int x)
        {
            InitializeComponent();
            controllerObj = new Controller();

            if (x == 2)   // If Trainer He Can not Delete 
            {
                DeleteClass.Enabled = false;
                DeletePlan.Enabled = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
