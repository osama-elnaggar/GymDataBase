using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBapplication
{
    public class MemberPaymentsController
    {

        DBManager dbMan;
        public MemberPaymentsController()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable GetPaymentNumber(int MemberID)
        {
            string query = "SELECT PaymentNu, Amount FROM Payments WHERE GymMemberID = " + MemberID + ";";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAllPayments(int MemberID)
        {
            string query = "SELECT PaymentNu, Amount,Date,GymMemberID   FROM Payments WHERE GymMemberID = " + MemberID + ";";

            return dbMan.ExecuteReader(query);
        }
        public string PayForGymMember(int MemberID, string CardNu, string cvv, int paymentNumber)
        {
            // Check if the card has enough balance
            string checkBalanceQuery = $"SELECT Balance FROM Allcardsintheworld WHERE CardNumber = '{CardNu}' AND CVV = '{cvv}';";
            DataTable cardData = dbMan.ExecuteReader(checkBalanceQuery);
            if (cardData.Rows.Count == 0)
            {
                return "Invalid card details.";
            }

            decimal cardBalance = Convert.ToDecimal(cardData.Rows[0]["Balance"]);

            // Get the payment amount
            string paymentQuery = $"SELECT PaymentNu, Amount FROM Payments WHERE GymMemberID = {MemberID} AND PaymentNu = {paymentNumber};";
            DataTable paymentData = dbMan.ExecuteReader(paymentQuery);
            if (paymentData.Rows.Count == 0)
            {
                return "No pending payment found.";
            }

            decimal paymentAmount = Convert.ToDecimal(paymentData.Rows[0]["Amount"]);

            // Check if the card balance is sufficient
            if (cardBalance < paymentAmount)
            {
                return "Insufficient balance.";
            }

            // Deduct the amount from the card balance
            string updateBalanceQuery = $"UPDATE Allcardsintheworld SET Balance = Balance - {paymentAmount} WHERE CardNumber = '{CardNu}' AND CVV = '{cvv}';";
            int updateResult = dbMan.ExecuteNonQuery(updateBalanceQuery);
            if (updateResult == 0)
            {
                return "Failed to deduct amount from the card.";
            }

            // Delete the payment row
            string deletePaymentQuery = $"DELETE FROM Payments WHERE GymMemberID = {MemberID} AND PaymentNu = {paymentNumber};";
            int deleteResult = dbMan.ExecuteNonQuery(deletePaymentQuery);
            if (deleteResult == 0)
            {
                return "Failed to delete the payment row.";
            }

            return "Payment successful.";
        }
    }
}
