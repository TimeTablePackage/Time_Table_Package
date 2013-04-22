using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetablePackage
{   
    class DataBase
    {

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ttp.accdb";
        private OleDbConnection conn ;
        private OleDbCommand cmd;
        private OleDbDataReader reader;
        
        /// <summary>
        ///     Connect to access database
        /// </summary>
        private void OpenConection()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connectionString ;
            try
             {
                conn.Open();
             }
            catch 
             {
                MessageBox.Show("Failed to connect to data source");
             }
        }
        /// <summary>
        ///     Disconnect from database
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to close connection to data source");
            }
        }
        /// <summary>
        ///    Get data back in a data table
        /// </summary>
        /// <param name="sqlStatment"></param>
        public DataTable GetTableData(String sqlStatment)
        {
            DataTable dt = new DataTable();
            OpenConection();
            OleDbCommand cmd = new OleDbCommand(sqlStatment, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            CloseConnection();
            return dt ;
        }
        /// <summary>
        ///    Get data back in string form
        /// </summary>
        /// <param name="sqlStatment"></param>
        public String GetData(String sqlStatment)
        {
            string outputString = "null";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        outputString = reader["Lec_Name"].ToString();
                        outputString += "$" + reader["Initials"].ToString();
                        outputString += "$" + reader["Email"].ToString();
                        outputString += "$" + reader["MaxHours"].ToString();
                        outputString += "$" + reader["MaxConsecHours"].ToString();
                        outputString += "$" + reader["MinSlotsPerDay"].ToString();
                        outputString += "$";
                    }
                    else
                    {
                        outputString = "N/A";
                    }
                }
                CloseConnection();
            }
            catch
            {
                MessageBox.Show("Failed to get data from source");
            }
            return outputString;
        }
        /// <summary>
        ///    insert data to a database
        /// </summary>
        /// <param name="sqlStatment"></param>
        public void insertString(String sqlString)
        {
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch
            {
                MessageBox.Show("Failed insert data");
            }
        }
    }
}

