using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBapplication
{
    internal class PlansAndClassController
    {
        DBManager dbMan;
        public PlansAndClassController()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int AddClass(string name, int capcity,TimeSpan Duration,string Schedule,int UserID,int price)
        {
            string query = $"INSERT INTO Class(Name,Capacity,Duration,Schedule,UserID,Price) VALUES('{name}',{capcity},'{Duration}','{Schedule}',{UserID},{price})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddPlan(string Description,string Goals, TimeSpan Time, int TrainerID,int Price)
        {
            string query = $"INSERT INTO WorkoutPlan(Description,Goals,Duration,TrainerID,Price) VALUES('{Description}','{Goals}','{Time}',{TrainerID},{Price})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteClass(int classID)
        {
            string query = $"DELETE FROM Class WHERE ID = {classID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeletePlan(int PlanID)
        {
            string query = $"DELETE FROM WorkoutPlan WHERE ID = {PlanID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ShowAllClasses()
        {
            string query = $"SELECT * FROM Class";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowAllPlans()
        {
            string query = $"SELECT * FROM WorkoutPlan";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SearchClassByName(string name)
        {
            string query = $"SELECT * FROM Class WHERE Name LIKE '%{name}%' ";
            return dbMan.ExecuteReader(query);
        }
        
            public DataTable GetallclassesByID(int id)
        {
            string query = $"SELECT * FROM Class WHERE UserID = {id} ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetallPlansByID(int id)
        {
            string query = $"SELECT * FROM WorkoutPlan WHERE TrainerID = {id} ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SearchPlanByGoals(string goal)
        {
            string query = $"SELECT * FROM WorkoutPlan WHERE CONVERT(VARCHAR,Goals) LIKE '%{goal}%' ";
            return dbMan.ExecuteReader(query);

        }
        public DataTable GetClassNames()
        {
            string query = $"SELECT Name From Class";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetPlanGoals()
        {
            string query = $"SELECT Goals FROM WorkoutPlan";
            return dbMan.ExecuteReader (query);
        }
        public DataTable GetTrainerID()
        {
            string query = $"SELECT ID FROM [User] WHERE Role = 'trainer'";
            return dbMan.ExecuteReader(query);
        }

    }
}