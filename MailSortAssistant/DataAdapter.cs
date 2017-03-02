using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MailSortAssistant
{
    /// <summary>
    /// Class: Allows the program to Read, Write, and Edit an excel sheet containing Faculty members.
    /// Developer: Kalin Bowden.
    /// Date: 03.01.2017.
    /// </summary>
    class DataAdapter
    {
        // Class level Variables.

        private static OleDbConnection conn;
        private static OleDbCommand cmd;
        private static OleDbDataReader reader;
        private static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Faculty.accdb";
        private static string query = "SELECT * FROM FacultyTable ORDER BY LastName ASC, FirstName ASC";
        private static Faculty current;
        private static Faculty[] facultyArray;


        /// <summary>
        /// Connect to the specified Excel worksheet.
        /// </summary>
        public static void Connect(string value, string column)
        {
            //TODO
            try
            {
                // Set Query to typed values.
                query = "SELECT * FROM EmployeesTable WHERE "+ column +" LIKE '" + value + "%'  ORDER BY Name ASC";

                // Establish connection.
                conn = new OleDbConnection(connString);
                conn.Open();

                // Create Comand;
                cmd = new OleDbCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;
            }
            catch
            {

            }
            finally
            {

            }
        }

        /// <summary>
        /// Disconnect from the specified Excel worksheet.
        /// </summary>
        public static void Disconnect()
        {
            //TODO
            try
            {
                reader.Close();
                conn.Close();
            }
            catch
            {

            }
            finally
            {

            }
        }

        public static Faculty[] Pull(string value, string column)
        {
            // Method level variables.
            facultyArray = new Faculty[1000];
            int index = 0;

            // Conntect to DB.
            Connect(value, column);

            //
            reader = cmd.ExecuteReader();
            while(reader.Read() && value != "")
            {
                // Create and set the faculty object.
                current = new Faculty();
                current.Name = reader["Name"].ToString();
                current.Dept = reader["Dept"].ToString();
                current.Note = reader["Note"].ToString();

                // Add faculty to the array.
                facultyArray[index++] = current;
            }
            index = 0;

            // Disconnect from DB;
            Disconnect();

            // Return the new array.
            return facultyArray;
        }

        //public static void Edit()
        //{
        //    // Conntect to DB.
        //    Connect();

        //    // Disconnect from DB;
        //    Disconnect();
        //}

        //public void Push()
        //{
        //    // Conntect to DB.
        //    Connect();

        //    // Disconnect from DB;
        //    Disconnect();
        //}

    }// End of Class
}// End od Solution
