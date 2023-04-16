namespace HandyPH
{
    partial class loginForm
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
            this.loginusernamelabel = new System.Windows.Forms.Label();
            this.login_usernametextBox = new System.Windows.Forms.TextBox();
            this.login_passwordlabel = new System.Windows.Forms.Label();
            this.login_passwordtextBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.loginform_signupbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginusernamelabel
            // 
            this.loginusernamelabel.AutoSize = true;
            this.loginusernamelabel.Location = new System.Drawing.Point(257, 229);
            this.loginusernamelabel.Name = "loginusernamelabel";
            this.loginusernamelabel.Size = new System.Drawing.Size(61, 13);
            this.loginusernamelabel.TabIndex = 0;
            this.loginusernamelabel.Text = "Username :";
            // 
            // login_usernametextBox
            // 
            this.login_usernametextBox.Location = new System.Drawing.Point(370, 229);
            this.login_usernametextBox.Name = "login_usernametextBox";
            this.login_usernametextBox.Size = new System.Drawing.Size(148, 20);
            this.login_usernametextBox.TabIndex = 1;
            // 
            // login_passwordlabel
            // 
            this.login_passwordlabel.AutoSize = true;
            this.login_passwordlabel.Location = new System.Drawing.Point(257, 261);
            this.login_passwordlabel.Name = "login_passwordlabel";
            this.login_passwordlabel.Size = new System.Drawing.Size(59, 13);
            this.login_passwordlabel.TabIndex = 2;
            this.login_passwordlabel.Text = "Password :";
            // 
            // login_passwordtextBox
            // 
            this.login_passwordtextBox.Location = new System.Drawing.Point(370, 258);
            this.login_passwordtextBox.Name = "login_passwordtextBox";
            this.login_passwordtextBox.Size = new System.Drawing.Size(148, 20);
            this.login_passwordtextBox.TabIndex = 3;
            this.login_passwordtextBox.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(432, 297);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // loginform_signupbutton
            // 
            this.loginform_signupbutton.Location = new System.Drawing.Point(432, 341);
            this.loginform_signupbutton.Name = "loginform_signupbutton";
            this.loginform_signupbutton.Size = new System.Drawing.Size(75, 23);
            this.loginform_signupbutton.TabIndex = 5;
            this.loginform_signupbutton.Text = "signup";
            this.loginform_signupbutton.UseVisualStyleBackColor = true;
            this.loginform_signupbutton.Click += new System.EventHandler(this.loginform_signupbutton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.loginform_signupbutton);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_passwordtextBox);
            this.Controls.Add(this.login_passwordlabel);
            this.Controls.Add(this.login_usernametextBox);
            this.Controls.Add(this.loginusernamelabel);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginusernamelabel;
        private System.Windows.Forms.TextBox login_usernametextBox;
        private System.Windows.Forms.Label login_passwordlabel;
        private System.Windows.Forms.TextBox login_passwordtextBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button loginform_signupbutton;
    }
}