namespace Handyman
{
    partial class SignUpForm
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
            this.txtSignUpUsername = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblSignUpUsername = new System.Windows.Forms.Label();
            this.lblSignUpPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSignUpUsername
            // 
            this.txtSignUpUsername.Location = new System.Drawing.Point(187, 25);
            this.txtSignUpUsername.Name = "txtSignUpUsername";
            this.txtSignUpUsername.Size = new System.Drawing.Size(100, 20);
            this.txtSignUpUsername.TabIndex = 0;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Location = new System.Drawing.Point(187, 62);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(100, 20);
            this.txtSignUpPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(187, 99);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // lblSignUpUsername
            // 
            this.lblSignUpUsername.AutoSize = true;
            this.lblSignUpUsername.Location = new System.Drawing.Point(121, 31);
            this.lblSignUpUsername.Name = "lblSignUpUsername";
            this.lblSignUpUsername.Size = new System.Drawing.Size(55, 13);
            this.lblSignUpUsername.TabIndex = 3;
            this.lblSignUpUsername.Text = "Username";
            // 
            // lblSignUpPassword
            // 
            this.lblSignUpPassword.AutoSize = true;
            this.lblSignUpPassword.Location = new System.Drawing.Point(123, 69);
            this.lblSignUpPassword.Name = "lblSignUpPassword";
            this.lblSignUpPassword.Size = new System.Drawing.Size(53, 13);
            this.lblSignUpPassword.TabIndex = 3;
            this.lblSignUpPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(212, 169);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Homeowner",
            "Handyman"});
            this.comboBox1.Location = new System.Drawing.Point(187, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "SELECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register As";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 204);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSignUpPassword);
            this.Controls.Add(this.lblSignUpUsername);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtSignUpPassword);
            this.Controls.Add(this.txtSignUpUsername);
            this.Name = "SignUpForm";
            this.Text = "Handy Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSignUpUsername;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblSignUpUsername;
        private System.Windows.Forms.Label lblSignUpPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}