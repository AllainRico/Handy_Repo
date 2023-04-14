namespace HandyPH
{
    partial class userHome
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
            this.userhome_handymanbutton = new System.Windows.Forms.Button();
            this.userhome_homeownerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userhome_handymanbutton
            // 
            this.userhome_handymanbutton.Location = new System.Drawing.Point(130, 177);
            this.userhome_handymanbutton.Name = "userhome_handymanbutton";
            this.userhome_handymanbutton.Size = new System.Drawing.Size(194, 123);
            this.userhome_handymanbutton.TabIndex = 0;
            this.userhome_handymanbutton.Text = "Handyman";
            this.userhome_handymanbutton.UseVisualStyleBackColor = true;
            this.userhome_handymanbutton.Click += new System.EventHandler(this.userhome_handymanbutton_Click);
            // 
            // userhome_homeownerbutton
            // 
            this.userhome_homeownerbutton.Location = new System.Drawing.Point(429, 177);
            this.userhome_homeownerbutton.Name = "userhome_homeownerbutton";
            this.userhome_homeownerbutton.Size = new System.Drawing.Size(194, 123);
            this.userhome_homeownerbutton.TabIndex = 1;
            this.userhome_homeownerbutton.Text = "Homeowner";
            this.userhome_homeownerbutton.UseVisualStyleBackColor = true;
            // 
            // userHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.userhome_homeownerbutton);
            this.Controls.Add(this.userhome_handymanbutton);
            this.Name = "userHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userhome_handymanbutton;
        private System.Windows.Forms.Button userhome_homeownerbutton;
    }
}