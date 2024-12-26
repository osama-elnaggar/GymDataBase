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
    public partial class MemberPayments : Form
    {
        MemberPaymentsController controllerObj;
        private int ID;
        public MemberPayments(int Memberid)
        {
            InitializeComponent();
            controllerObj = new MemberPaymentsController();
            DataTable dt = controllerObj.GetPaymentNumber(Memberid);
            DataTable dt2 = controllerObj.GetAllPayments(Memberid);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();

            PaymentNoCombobox.DataSource = dt;
            PaymentNoCombobox.DisplayMember = "Payment Number";
            ID= Memberid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CardNuBox.Text) || string.IsNullOrEmpty(CVVBox.Text))
                {
                    MessageBox.Show("Please enter valid Card Number and CVV.");
                    return;
                }

                if (PaymentNoCombobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid Payment Number.");
                    return;
                }

                // Use MemberID class-level variable
                int paymentNumber = Int32.Parse(PaymentNoCombobox.SelectedItem.ToString());
                int x = ID;
                string result = controllerObj.PayForGymMember(x, CardNuBox.Text, CVVBox.Text, paymentNumber);
                MessageBox.Show(result);
            }
            catch (Exception E)
            { MessageBox.Show("Wrong Card Number Or No Enought Amount in Balance to pay..."); }

        }

        private void MemberPayments_Load(object sender, EventArgs e)
        {

        }
    }
}

