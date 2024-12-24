using System;
using System.Collections.Generic;
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

    }
}
