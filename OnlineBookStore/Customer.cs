using System;
using System.Data.SqlClient;
using System.Drawing;       //  Image instance.
using System.Linq;          //  Any function()
using System.Windows.Forms; //  MessageBox

namespace OnlineBookStore
{
    class Customer
    {
        /*  ATTRIBUTES      */
        private int id;
        private string username;
        private string password;
        private string name;
        private string address;
        private string email;
        private string gender;
        private Image image;


        private static SqlDataAdapter DATA_ADAPTER;
        public static SqlDataAdapter GetDataAdapter()
        {
            try
            {
                if (DATA_ADAPTER == null)
                    DATA_ADAPTER = new SqlDataAdapter(GetSelectCommand(), DatabaseHandler.CONNECTION_STRING);

                return DATA_ADAPTER;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }



        /*  Singleton Design Pattern    */
        private static Customer instance;
        private Customer() { }
        public static Customer GetInstance()
        {
            return (instance == null) ? instance = new Customer() : null;
        }



        /*  Getters & Setters   */
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Username must be entered!");
                else
                    username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Password must be entered!");
                else if (value.Length < 6)
                    throw new ArgumentOutOfRangeException("Password length must be at least 6 characters long.");
                else if (value.Contains(username))
                    throw new ArgumentException("Password cannot contain username!");
                else if (!value.Any(char.IsDigit))
                    throw new ArgumentException("Password must contains at least one number!");
                else
                    password = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name must be entered!");
                else
                    name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address must be entered!");
                else
                    address = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                var addr = new System.Net.Mail.MailAddress(value);

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Email must be entered!");
                else if (addr.Address == email)
                    throw new ArgumentException("Email address is not valid!");
                else
                    email = value;
            }
        }

        //  Below attributes can be null.
        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }



        /*  SQL Commands For Customer Class  */
        public static string GetSelectCommand()
        {
            return "SELECT * FROM tblCustomer";
        }
        public static string GetInsertCommand()
        {
            return "INSERT INTO tblCustomer values(@username, @password, @name, @address, @email, @gender);";
        }
        public static string GetDeleteCommand()
        {
            return "DELETE FROM tblCustomer WHERE username=@username OR email=@email;";
        }
    }
}
