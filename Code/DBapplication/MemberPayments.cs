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
			comboBox1.Items.Add("1 Year");
			comboBox1.Items.Add("3 Months");
			comboBox1.Items.Add("1 Month");
			comboBox1.SelectedIndex = 0;

			ID = Memberid;
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

				int result = controllerObj.AddPoints(Int16.Parse(textBox1.Text), CardNuBox.Text, CVVBox.Text, ID);
				if(result == -2)
				{
					MessageBox.Show("Card Info Are Not Correct...");
				}
				else if (result == -1)
				{
					MessageBox.Show("No Enough Balance in card...");
				}
				else if(result == 0)
				{
					MessageBox.Show("Payment Failed!, May data Entered Be wrong");
				}
				else if(result < 0)
                {
					MessageBox.Show("Error Happened!, Check data Entered ?");
				}
				else
				{
					MessageBox.Show("Payment made successfully!");
					DataTable dt2 = controllerObj.GetAllPayments(ID);
					dataGridView1.DataSource = dt2;
					dataGridView1.Refresh();
				}
			  
				
			}
			catch (Exception E)
			{ MessageBox.Show("Wrong Card Number Or No Enought Amount in Balance to pay..."); }

		}

		private void MemberPayments_Load(object sender, EventArgs e)
		{

		}

		private void PaymentNoCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int result = controllerObj.GetPoints(ID);

				if (result == 0)
				{
					MessageBox.Show("Error Happened...");
				}
				else
				{
					pointsLabel.Text = $"Points: {result}"; // Set the text of the label to display the points.
					pointsLabel.Show(); // Ensure the label is visible.
				}

			}
			catch (Exception E)
			{
				MessageBox.Show("Wrong Data Inserted...");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int result = controllerObj.BuyPlan(ID, comboBox1.SelectedItem.ToString());

				if (result <= 0)
					MessageBox.Show("Error Happened Make Sure you have Enought Balance ?");
				else
				{
					MessageBox.Show("Plan Registered Successfully...");
					DataTable dt2 = controllerObj.GetAllPayments(ID);
					dataGridView1.DataSource = dt2;
					dataGridView1.Refresh();
				}
			}
			catch (Exception E)
			{ MessageBox.Show("Wrong Data Inserted..."); }

		}

	}
}

