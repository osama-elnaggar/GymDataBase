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
    public partial class FeedBack : Form
    {
        GymMemberController controllerObj;
        int MemberID;
        public FeedBack(int ID)
        {
            InitializeComponent();
            controllerObj = new GymMemberController();
            MemberID = ID;
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x = controllerObj.AddFeedBack()
        }
    }
}
