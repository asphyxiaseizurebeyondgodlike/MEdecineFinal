using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MEdecineFinal
{
    internal class database
    {
        SqlConnection db = new SqlConnection(@"Data Source = DESKTOP-BD9J92E\SQLEXPRESS;Initial Catalog = FinalMedecine;Integrated Security = True");

        public void OpenConnection()
        {
            if(db.State == System.Data.ConnectionState.Closed)
            {
                db.Open();
            }
        }
        public void CloseConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)
            {
                db.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return db;
        }
    }

 
}
