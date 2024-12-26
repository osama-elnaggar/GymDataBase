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

    }
}
