﻿using System;
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
       
        public DataTable CheckCreedentials(string UserName,string Password)
        {

            string query = $"SELECT * FROM GymMember WHERE UserName = '{UserName}' AND Password = '{Password}' ";

            return dbMan.ExecuteReader(query);
        }

      
    }
}
