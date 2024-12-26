using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBapplication
{
    public class GymMemberController
    {
        DBManager dbMan;
        public GymMemberController()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int GymMemberSignup(string Username, string Password, System.DateTime BDate,
            string Gender, string phone, string email,
            string payment_history, string MembershipStatus)
        {
            string query = $"INSERT INTO GymMember(UserName,Password,BirthDate,Gender,Phone,Email,PaymentHistory,MembershipStatus)" +
                $" VALUES('{Username}','{Password}','{BDate}'," +
                $"'{Gender}','{phone}','{email}','{payment_history}','{MembershipStatus}')";
            return (dbMan.ExecuteNonQuery(query));
        }

        public DataTable Getworkouts()
        {
            string query = $"SELECT * FROM WorkoutPlan";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPlanID()
        {
            string query = $"SELECT ID FROM WorkoutPlan";
            return dbMan.ExecuteReader(query);
        }

        public int RegisterPlan(int PlanID, int MemberID,System.DateTime Date)
        {
            string query = $"INSERT INTO RegisterWorkoutPlan(PlanID,MemberID,Date)" +
                $" VALUES({PlanID},{MemberID},'{Date}') ";

            return dbMan.ExecuteNonQuery(query);
        }

        //public DataTable GetRegisterdWorkouts(int MemberID)
        //{
        //    string query = $"SELECT WP.Description,WP.Goals,WP.Duration,U.FirstName " +
        //        $"FROM User AS U JOIN WorkoutPlan AS W" +
        //        $"ON U.";
        //}

        /*SELECT e.first_name, d.department_name
FROM employees AS e
JOIN departments AS d
ON e.department_id = d.department_id;*/

        public int AddFeedBack(string comments,System.DateTime Date,int TrainerID,int MemberID)
        {
            string query = $"INSERT INTO Feedback(Comments,Date,TrainerID,GymMemberID)" +
                $"VALUES('{comments}','{Date}',{TrainerID},{MemberID})";

            return dbMan.ExecuteNonQuery(query);

        }

<<<<<<< Updated upstream
=======
        public DataTable GetClasses()
        {
            string query = $"SELECT C.ID,C.Name,C.Duration,C.Schedule,U.FirstName FROM Class AS C JOIN [User] AS U ON U.ID = C.UserID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetClassID()
        {
            string query = $"SELECT ID FROM Class";
            return dbMan.ExecuteReader(query);
        }

        public int BookClass(int MemberID,int classID,System.DateTime date)
        {
            string query = $"INSERT INTO GymMemberBooksClass(MemberID,ClassID,BookDate) VALUES ({MemberID},{classID},'{date}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAttends(int memberID)
        {
            string query = $"SELECT C.ID,C.Name,C.Duration,C.Schedule,U.FirstName FROM Class AS C JOIN [User] AS U ON U.ID = C.UserID " +
                $"JOIN GymMemberBooksClass AS GMC ON C.ID = GMC.ClassID WHERE MemberID = {memberID}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAttendID(int memberID)
        {
            string query = $"SELECT C.ID FROM Class AS C JOIN [User] AS U ON U.ID = C.UserID JOIN GymMemberBooksClass AS GMC ON C.ID = GMC.ClassID WHERE MemberID = {memberID}";
            return dbMan.ExecuteReader(query);
        }

        public int Attends(int MemberID, int classID, System.DateTime date)
        {
            string query = $"INSERT INTO AttendClass(ClassID,MemberID,AttendDate) VALUES({classID},{MemberID},'{date}')";
            return dbMan.ExecuteNonQuery(query);

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
>>>>>>> Stashed changes
    }

}
