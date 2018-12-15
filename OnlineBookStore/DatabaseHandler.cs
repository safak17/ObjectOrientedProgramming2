using System;
using System.Collections.Generic;
using System.Data.SqlClient;        //  SqlConnection
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;                   //  WebClient
using System.Windows.Forms;         //  MessageBox
using System.Data;                  //  DataSet

namespace OnlineBookStore
{
    class DatabaseHandler
    {
        /*  ATTRIBUTES      */
        private static string SERVER    = "den1.mssql5.gear.host";
        private static string DATABASE  = "oop2";
        private static string USER_ID   = "oop2";
        private static string PASSWORD  = "Lk9L3n51Bx~~";


        //  https://stackoverflow.com/questions/11141062/load-all-tables-of-a-database-in-a-single-dataset
        DataSet ONLINE_BOOK_STORE_DATABASE      = new DataSet();
        public static string CONNECTION_STRING  = "Data Source=" + SERVER + "; Initial Catalog=" + DATABASE + "; User Id=" + USER_ID + "; Password=" + PASSWORD + ";";
        SqlConnection SQL_CONNECTION            = new SqlConnection(CONNECTION_STRING);





        /*  Singleton Design Pattern   */
        private static DatabaseHandler instance;
        private DatabaseHandler() { }
        public static DatabaseHandler GetInstance()
        {
            return (instance == null) ? (instance = new DatabaseHandler()) : instance;
        }



        private bool GetAllTables(string[] tableNames)
        {
            try
            {
                //  Her bir tablo için dataadapter gerekli ve ONLINE_BOOK_STORE_DATABASE bu tablo eklenmeli.
                foreach (string sourceTableName in tableNames)
                {
                    SqlDataAdapter daCustomer = Customer.GetDataAdapter();
                    DataTable tbCustomer = new DataTable(sourceTableName);

                    daCustomer.Fill(ONLINE_BOOK_STORE_DATABASE, sourceTableName);
                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show( error.Message );
                return false;
            }
        }

        /*****  CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER      *****/
        public bool IsCustomerExist(string username, string email)
        {
            return HasUsernameAlreadyTaken(username) && HasEmailAlreadyTaken(email);
        }
        public bool HasEmailAlreadyTaken(string email)
        {
            string sqlString = "SELECT * FROM tblCustomer WHERE email = @email";
            SqlCommand sqlCommand = new SqlCommand(sqlString, SQL_CONNECTION);
            sqlCommand.Parameters.AddWithValue("@email", email);

            try
            {
                SQL_CONNECTION.Open();
                object obj = Customer.GetDataAdapter().SelectCommand.ExecuteScalar();
                SQL_CONNECTION.Close();

                return (obj != null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
        public bool HasUsernameAlreadyTaken(string username)
        {
            string sqlString = "SELECT * FROM tblCustomer WHERE username = @username";
            SqlCommand sqlCommand = new SqlCommand(sqlString, SQL_CONNECTION);
            sqlCommand.Parameters.AddWithValue("@username", username);

            try
            {
                SQL_CONNECTION.Open();
                object obj = Customer.GetDataAdapter().SelectCommand.ExecuteScalar();       //  Sonuç tablosunun ilk satırını döndürür.
                SQL_CONNECTION.Close();

                return (obj != null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        /*  CUSTOMER SQL COMMANDS   */
        public bool InsertCustomer(Customer customer)
        {
            string sqlString = Customer.GetInsertCommand();

            SqlCommand sqlCommand = new SqlCommand(sqlString, SQL_CONNECTION);
            sqlCommand.Parameters.AddWithValue("@username", customer.Username);
            sqlCommand.Parameters.AddWithValue("@password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@address", customer.Address);
            sqlCommand.Parameters.AddWithValue("@email", customer.Email);
            sqlCommand.Parameters.AddWithValue("@gender", customer.Gender);

            try
            {
                SQL_CONNECTION.Open();
                Customer.GetDataAdapter().InsertCommand = sqlCommand;
                int numberOfAffectedRows = Customer.GetDataAdapter().InsertCommand.ExecuteNonQuery();       //  Etkilenen satır sayısını döndürür.
                SQL_CONNECTION.Close();

                return numberOfAffectedRows == 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
        public bool DeleteCustomer(string username, string email)
        {
            string sqlString = Customer.GetDeleteCommand();
            SqlCommand sqlCommand = new SqlCommand(sqlString, SQL_CONNECTION);
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@email", email);

            try
            {
                SQL_CONNECTION.Open();
                Customer.GetDataAdapter().DeleteCommand = sqlCommand;
                int numberOfAffectedRows = Customer.GetDataAdapter().DeleteCommand.ExecuteNonQuery();       //  Etkilenen satır sayısını döndürür.
                SQL_CONNECTION.Close();

                return numberOfAffectedRows == 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }
        //  UpdateCustomer ?



        
        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no internet connection!");
                return false;
            }
        }
    }
}
