namespace OnlineBookStore
{
    partial class UserSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSignupUsername = new System.Windows.Forms.TextBox();
            this.btnSignupSignup = new System.Windows.Forms.Button();
            this.tbSignupPassword = new System.Windows.Forms.TextBox();
            this.tbSignupName = new System.Windows.Forms.TextBox();
            this.tbSignupAddress = new System.Windows.Forms.TextBox();
            this.tbSignupEmail = new System.Windows.Forms.TextBox();
            this.tbSignupGender = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSignupUsername
            // 
            this.tbSignupUsername.Location = new System.Drawing.Point(37, 55);
            this.tbSignupUsername.Name = "tbSignupUsername";
            this.tbSignupUsername.Size = new System.Drawing.Size(223, 26);
            this.tbSignupUsername.TabIndex = 0;
            this.tbSignupUsername.Text = "username";
            // 
            // btnSignupSignup
            // 
            this.btnSignupSignup.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSignupSignup.ForeColor = System.Drawing.Color.Black;
            this.btnSignupSignup.Location = new System.Drawing.Point(37, 379);
            this.btnSignupSignup.Name = "btnSignupSignup";
            this.btnSignupSignup.Size = new System.Drawing.Size(223, 39);
            this.btnSignupSignup.TabIndex = 6;
            this.btnSignupSignup.Text = "SignUp";
            this.btnSignupSignup.UseVisualStyleBackColor = false;
            this.btnSignupSignup.Click += new System.EventHandler(this.btnSignupSignup_Click);
            // 
            // tbSignupPassword
            // 
            this.tbSignupPassword.Location = new System.Drawing.Point(37, 107);
            this.tbSignupPassword.Name = "tbSignupPassword";
            this.tbSignupPassword.Size = new System.Drawing.Size(223, 26);
            this.tbSignupPassword.TabIndex = 1;
            this.tbSignupPassword.Text = "password1";
            // 
            // tbSignupName
            // 
            this.tbSignupName.Location = new System.Drawing.Point(37, 159);
            this.tbSignupName.Name = "tbSignupName";
            this.tbSignupName.Size = new System.Drawing.Size(223, 26);
            this.tbSignupName.TabIndex = 2;
            this.tbSignupName.Text = "name";
            // 
            // tbSignupAddress
            // 
            this.tbSignupAddress.Location = new System.Drawing.Point(37, 215);
            this.tbSignupAddress.Name = "tbSignupAddress";
            this.tbSignupAddress.Size = new System.Drawing.Size(223, 26);
            this.tbSignupAddress.TabIndex = 3;
            this.tbSignupAddress.Text = "address";
            // 
            // tbSignupEmail
            // 
            this.tbSignupEmail.Location = new System.Drawing.Point(37, 268);
            this.tbSignupEmail.Name = "tbSignupEmail";
            this.tbSignupEmail.Size = new System.Drawing.Size(223, 26);
            this.tbSignupEmail.TabIndex = 4;
            this.tbSignupEmail.Text = "email@gmail.com";
            // 
            // tbSignupGender
            // 
            this.tbSignupGender.Location = new System.Drawing.Point(37, 328);
            this.tbSignupGender.Name = "tbSignupGender";
            this.tbSignupGender.Size = new System.Drawing.Size(223, 26);
            this.tbSignupGender.TabIndex = 5;
            this.tbSignupGender.Text = "gender";
            // 
            // UserSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 492);
            this.Controls.Add(this.tbSignupGender);
            this.Controls.Add(this.tbSignupEmail);
            this.Controls.Add(this.tbSignupAddress);
            this.Controls.Add(this.tbSignupName);
            this.Controls.Add(this.tbSignupPassword);
            this.Controls.Add(this.btnSignupSignup);
            this.Controls.Add(this.tbSignupUsername);
            this.Name = "UserSignUp";
            this.Text = "UserSignUp";
            this.Load += new System.EventHandler(this.UserSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSignupUsername;
        private System.Windows.Forms.Button btnSignupSignup;
        private System.Windows.Forms.TextBox tbSignupPassword;
        private System.Windows.Forms.TextBox tbSignupName;
        private System.Windows.Forms.TextBox tbSignupAddress;
        private System.Windows.Forms.TextBox tbSignupEmail;
        private System.Windows.Forms.TextBox tbSignupGender;
    }
}