using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }



        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable CheckCreedentials(string UserName, string Password)
        {

            string query = $"SELECT * FROM GymMember WHERE UserName = '{UserName}' AND Password = '{Password}' ";

            return dbMan.ExecuteReader(query);
        }
        public int getID(string UserName, string Password)
        {
            string query = $"SELECT ID FROM GymMember WHERE UserName = '{UserName}' AND Password = '{Password}' ";
            DataTable t = dbMan.ExecuteReader(query);
            int x = Convert.ToInt32(t.Rows[0][0]);
            return x;
        }

        public DataTable CheckCreedentialsForUser(string Email, string Pass)
        {

            string query = $"SELECT * FROM [User] WHERE Email = '{Email}' AND Password = '{Pass}' ";

            return dbMan.ExecuteReader(query);
        }
        public string GetUserRole(string Email, string Pass)
        {

            string query = $"SELECT * FROM [User] WHERE Email = '{Email}' AND Password = '{Pass}' ";

            DataTable D = dbMan.ExecuteReader(query);


            if (D != null && D.Rows.Count > 0)
            {
                return D.Rows[0]["Role"].ToString();
            }
            else
            {
                return "User Not Found...";
            }
        }

        public int getIDForUser(string Email, string Pass)
        {
            string query = $"SELECT ID FROM [User] WHERE Email = '{Email}' AND Password = '{Pass}' ";
            DataTable t = dbMan.ExecuteReader(query);
            int x = Convert.ToInt32(t.Rows[0][0]);
            return x;
        }

        public int AddGymMember(string FirstName, string LastName, string Gender, string Phone, string Email, string Password, string PaymentHistory, DateTime? BirthDate, DateTime? PlanFinishDate)
        {
            string query = $"INSERT INTO GymMember (UserName, Password, Gender, Phone, Email, PaymentHistory, BirthDate, PlanFinishData, Points)  " +
                           $"VALUES ('{FirstName}', '{Password}', '{Gender}', '{Phone}', '{Email}', 'Nothing' , '{BirthDate}', null , 0);";
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            return rowsAffected;
        }
        public int DeleteGymMember(int MemberID)
        {
            string query = $"DELETE FROM GymMember WHERE ID = {MemberID}";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected;

        }
        public DataTable ShowMember(string Email, string Pass)
        {

            string query = $"SELECT * FROM GymMember WHERE Email = '{Email}' AND Password = '{Pass}' ";

            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowAllMembers()
        {

            string query = $"SELECT * FROM GymMember";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SearchmemberByname(string Username)
        {

            string query = $"SELECT * FROM GymMember WHERE UserName LIKE '%{Username}%'; ";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetFeedBack(int id)
        {
            string query = $"SELECT * FROM Feedback WHERE TrainerID = {id}";
            return dbMan.ExecuteReader(query);
        }
    }
}


