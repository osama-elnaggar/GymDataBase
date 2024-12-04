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
       
        public int GymMemberSignup(int ID, string FirstName,string LastName,string BDate,
            string Gender,string phone,string email,
            string payment_history,string MembershipStatus )
        {
            string query = $"INSERT INTO GymMember(ID,FirstName,LastName,BirthDate,Gender,Phone,Email,PaymentHistory,MembershipStatus)" +
                $" VALUES({ID},'{FirstName}','{LastName}','{BDate}'," +
                $"'{Gender}','{phone}','{email}','{payment_history}','{MembershipStatus}')";
            return (dbMan.ExecuteNonQuery( query ));
        }
      
    }
}
