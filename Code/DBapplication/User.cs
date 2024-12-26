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
    public partial class User : Form
    {
        Controller controllerObj;
        private int ID;
        public User(int UserNumber, int id)    // 1 For Admin, 2 For Trainer, 3 For Worker
        {
            controllerObj = new Controller();
            ID = id;
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
