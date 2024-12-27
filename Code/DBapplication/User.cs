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
        private int UserNu;
        public User(int UserNumber, int id)    // 1 For Admin, 2 For Trainer, 3 For Worker
        {
            controllerObj = new Controller();
            ID = id;
            UserNu = UserNumber;
            InitializeComponent();
            if (UserNumber == 3)
            {
                DeleteMember.Enabled = false;
                ManageClassesandplans.Enabled = false;
                ModifyUsers.Enabled = false;
                SeeFeedBack.Enabled = false;
            }
            else if (UserNumber == 2)
            {
                DeleteMember.Enabled = false;
                ModifyUsers.Enabled = false;
            }

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            Form f = new AddMember();
            f.Show();

        }

        private void DeleteMember_Click(object sender, EventArgs e)
        {
            Form form = new DeleteMember();
            form.Show();
        }

        private void ManageClassesandplans_Click(object sender, EventArgs e)
        {
            Form form = new PlansandClassesForm(UserNu,ID);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new ReciveFeedBack(ID);
            form.Show();
        }
    }
}
