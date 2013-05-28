using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace TeleRadReport
{
    class Myconnectionclass
    {
        public OdbcConnection DBConnection;
        public void OpenConnection()
        {
            DBConnection = new OdbcConnection("DSN=DicomServerDB;uid=sa;pwd=Db2011");
            DBConnection.Open();
        }


        public void closeconnection()
        {
            DBConnection.Close();
        }
    }
}
