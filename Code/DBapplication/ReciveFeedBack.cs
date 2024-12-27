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
    public partial class ReciveFeedBack : Form
    {
        Controller controllerObj;
        int ID;
        public ReciveFeedBack(int ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.DataSource = controllerObj.GetFeedBack(ID);
        }

        private void ReciveFeedBack_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
