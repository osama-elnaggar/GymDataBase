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
        public int AddPoints(int amount, string CardNu, string cvv, int id)
        {
            // Check if the card has enough balance
            string checkBalanceQuery = $"SELECT Balance FROM Allcardsintheworld WHERE CardNumber = '{CardNu}' AND CVV = '{cvv}';";
            DataTable cardData = dbMan.ExecuteReader(checkBalanceQuery);
            if (cardData.Rows.Count == 0)
            {
                return -2; // Card data Wrong
            }

            decimal cardBalance = Convert.ToDecimal(cardData.Rows[0]["Balance"]);

            if (cardBalance < amount)
            {
                return -1; // No enough balance
            }
     
            DateTime date = DateTime.Now;
            string query = $"INSERT INTO Payments(Amount, Date, GymMemberID, UserID)" +
                $"VALUES({amount},'{date}',{id},9)";
            int result = dbMan.ExecuteNonQuery(query);

            // Update Member Points Balance
            string updatePointsQuery = $"UPDATE GymMember SET Points = Points + {amount} WHERE ID = {id};";
            int updateResult = dbMan.ExecuteNonQuery(updatePointsQuery);
            if (updateResult <= 0)
                return -10;

            string updateCardBalanceQuery = $"UPDATE Allcardsintheworld SET Balance = Balance - {amount} " +
                                  $"WHERE CardNumber = '{CardNu}' AND CVV = '{cvv}';";
             dbMan.ExecuteNonQuery(updateCardBalanceQuery);

            return result;

        }
        public int GetPoints(int id)
        {
            string query = $"SELECT Points FROM GymMember WHERE ID = {id};";
            DataTable result = dbMan.ExecuteReader(query); // ExecuteReader is used to fetch data

            if (result.Rows.Count > 0)
            {
                // Return the Points value as an integer
                return Convert.ToInt32(result.Rows[0]["Points"]);
            }
            else
            {
                // Return -1 if the user is not found
                return -1;
            }
        }
        public int BuyPlan(int id, string plan)
        {
            int Price = 0;
            int monthsToAdd = 0;

            // Determine the plan price and duration
            if (plan == "1 Year")
            {
                Price = 100;
                monthsToAdd = 12; // Add 12 months
            }
            else if (plan == "3 Months")
            {
                Price = 40;
                monthsToAdd = 3; // Add 3 months
            }
            else if (plan == "1 Month")
            {
                Price = 20;
                monthsToAdd = 1; // Add 1 month
            }
            else
            {
                return -4; // Invalid plan
            }

            // Fetch the current points and current plan end date of the member
            string getMemberDataQuery = $"SELECT Points, PlanFinishData FROM GymMember WHERE ID = {id};";
            DataTable memberData = dbMan.ExecuteReader(getMemberDataQuery);

            if (memberData.Rows.Count == 0)
            {
                return -1; // Member not found
            }

            int currentPoints = Convert.ToInt32(memberData.Rows[0]["Points"]);
            DateTime currentEndDate;

         
            if (memberData.Rows[0]["PlanFinishData"] == DBNull.Value)
            {
                currentEndDate = DateTime.Now; 
            }
            else
            {
                currentEndDate = Convert.ToDateTime(memberData.Rows[0]["PlanFinishData"]);
            }

            if (currentPoints < Price)
            {
                return -2; 
            }

            
            // Insert a record into the Payments table with a negative amount
            DateTime date = DateTime.Now;
            string insertPaymentQuery = $"INSERT INTO Payments (Amount, Date, GymMemberID, UserID) VALUES (-{Price}, '{date}', {id}, 9);";
            dbMan.ExecuteNonQuery(insertPaymentQuery);

            // Calculate the new end date
            DateTime newEndDate = currentEndDate > DateTime.Now ? currentEndDate.AddMonths(monthsToAdd) : DateTime.Now.AddMonths(monthsToAdd);


            string updateMemberQuery = $"UPDATE GymMember SET Points = Points - {Price}, PlanFinishData = '{newEndDate:yyyy-MM-dd}' WHERE ID = {id};";
            int result = dbMan.ExecuteNonQuery(updateMemberQuery);
            return result;
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
