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
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

       
        /*  Placeholder for Username and Password Textboxes.*/
        private void tbUserEmail_Enter(object sender, EventArgs e)
        {
            if (tbLoginUsername.Text == "Username")
            {
                tbLoginUsername.Text = "";
                tbLoginUsername.ForeColor = Color.Black;
            }
        }
        private void tbUserEmail_Leave(object sender, EventArgs e)
        {
            if (tbLoginUsername.Text == "")
            {
                tbLoginUsername.Text = "Username";
                tbLoginUsername.ForeColor = Color.Silver;
            }
        }
        private void tbUserPassword_Enter(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "Password")
            {
                tbLoginPassword.Text = "";
                tbLoginPassword.ForeColor = Color.Black;
            }
        }
        private void tbUserPassword_Leave(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "")
            {
                tbLoginPassword.Text = "Password";
                tbLoginPassword.ForeColor = Color.Silver;
            }
        }




        /*  Login Buttons   */
        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            ShowSignUpForm();
        }

        private void ShowSignUpForm()
        {
            this.Hide();
            Form UserSignUpForm = new UserSignUp();

            UserSignUpForm.Show();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            denme xxx = new denme();
            xxx.Show();
        }
    }
}
