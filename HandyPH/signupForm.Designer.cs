namespace HandyPH
{
    partial class signupForm
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
            this.signupform_passwordtextBox = new System.Windows.Forms.TextBox();
            this.login_passwordlabel = new System.Windows.Forms.Label();
            this.signupform_usernametextBox = new System.Windows.Forms.TextBox();
            this.loginusernamelabel = new System.Windows.Forms.Label();
            this.signupform_confirmpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupform_signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupform_passwordtextBox
            // 
            this.signupform_passwordtextBox.Location = new System.Drawing.Point(409, 264);
            this.signupform_passwordtextBox.Name = "signupform_passwordtextBox";
            this.signupform_passwordtextBox.Size = new System.Drawing.Size(148, 20);
            this.signupform_passwordtextBox.TabIndex = 8;
            this.signupform_passwordtextBox.UseSystemPasswordChar = true;
            // 
            // login_passwordlabel
            // 
            this.login_passwordlabel.AutoSize = true;
            this.login_passwordlabel.Location = new System.Drawing.Point(262, 267);
            this.login_passwordlabel.Name = "login_passwordlabel";
            this.login_passwordlabel.Size = new System.Drawing.Size(59, 13);
            this.login_passwordlabel.TabIndex = 7;
            this.login_passwordlabel.Text = "Password :";
            // 
            // signupform_usernametextBox
            // 
            this.signupform_usernametextBox.Location = new System.Drawing.Point(409, 235);
            this.signupform_usernametextBox.Name = "signupform_usernametextBox";
            this.signupform_usernametextBox.Size = new System.Drawing.Size(148, 20);
            this.signupform_usernametextBox.TabIndex = 6;
            // 
            // loginusernamelabel
            // 
            this.loginusernamelabel.AutoSize = true;
            this.loginusernamelabel.Location = new System.Drawing.Point(262, 235);
            this.loginusernamelabel.Name = "loginusernamelabel";
            this.loginusernamelabel.Size = new System.Drawing.Size(61, 13);
            this.loginusernamelabel.TabIndex = 5;
            this.loginusernamelabel.Text = "Username :";
            // 
            // signupform_confirmpasswordtextBox
            // 
            this.signupform_confirmpasswordtextBox.Location = new System.Drawing.Point(409, 290);
            this.signupform_confirmpasswordtextBox.Name = "signupform_confirmpasswordtextBox";
            this.signupform_confirmpasswordtextBox.Size = new System.Drawing.Size(148, 20);
            this.signupform_confirmpasswordtextBox.TabIndex = 10;
            this.signupform_confirmpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirm Password :";
            // 
            // signupform_signupButton
            // 
            this.signupform_signupButton.Location = new System.Drawing.Point(457, 332);
            this.signupform_signupButton.Name = "signupform_signupButton";
            this.signupform_signupButton.Size = new System.Drawing.Size(75, 23);
            this.signupform_signupButton.TabIndex = 11;
            this.signupform_signupButton.Text = "Sign Up";
            this.signupform_signupButton.UseVisualStyleBackColor = true;
            this.signupform_signupButton.Click += new System.EventHandler(this.signupform_signupButton_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.signupform_signupButton);
            this.Controls.Add(this.signupform_confirmpasswordtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupform_passwordtextBox);
            this.Controls.Add(this.login_passwordlabel);
            this.Controls.Add(this.signupform_usernametextBox);
            this.Controls.Add(this.loginusernamelabel);
            this.Name = "signupForm";
            this.Text = "signupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signupform_passwordtextBox;
        private System.Windows.Forms.Label login_passwordlabel;
        private System.Windows.Forms.TextBox signupform_usernametextBox;
        private System.Windows.Forms.Label loginusernamelabel;
        private System.Windows.Forms.TextBox signupform_confirmpasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupform_signupButton;
    }
}