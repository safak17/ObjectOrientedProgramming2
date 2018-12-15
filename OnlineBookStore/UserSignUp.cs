using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignupSignup_Click(object sender, EventArgs e)
        {
            Customer customer = Customer.GetInstance();
            customer.Username = tbSignupUsername.Text;
            customer.Password = tbSignupPassword.Text;
            customer.Name = tbSignupName.Text;
            customer.Address = tbSignupAddress.Text;
            customer.Email = tbSignupEmail.Text;
            customer.Gender = tbSignupGender.Text;

            if (DatabaseHandler.GetInstance().IsCustomerExist(customer.Username, customer.Email))
                MessageBox.Show("This user has already exist. Please try again with different username or email!");
            else
                DatabaseHandler.GetInstance().InsertCustomer(customer);
        }
    }
}
