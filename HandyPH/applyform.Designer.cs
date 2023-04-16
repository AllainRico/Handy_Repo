namespace HandyPH
{
    partial class applyform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applyform_jobidTextBox = new System.Windows.Forms.TextBox();
            this.applyform_handymanIDtextbox = new System.Windows.Forms.TextBox();
            this.applyform_paymentTextBox = new System.Windows.Forms.TextBox();
            this.applyform_applyjobButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Handyman ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment";
            // 
            // applyform_jobidTextBox
            // 
            this.applyform_jobidTextBox.Location = new System.Drawing.Point(124, 37);
            this.applyform_jobidTextBox.Name = "applyform_jobidTextBox";
            this.applyform_jobidTextBox.ReadOnly = true;
            this.applyform_jobidTextBox.Size = new System.Drawing.Size(100, 20);
            this.applyform_jobidTextBox.TabIndex = 3;
            // 
            // applyform_handymanIDtextbox
            // 
            this.applyform_handymanIDtextbox.Location = new System.Drawing.Point(124, 66);
            this.applyform_handymanIDtextbox.Name = "applyform_handymanIDtextbox";
            this.applyform_handymanIDtextbox.ReadOnly = true;
            this.applyform_handymanIDtextbox.Size = new System.Drawing.Size(100, 20);
            this.applyform_handymanIDtextbox.TabIndex = 4;
            // 
            // applyform_paymentTextBox
            // 
            this.applyform_paymentTextBox.Location = new System.Drawing.Point(124, 98);
            this.applyform_paymentTextBox.Name = "applyform_paymentTextBox";
            this.applyform_paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.applyform_paymentTextBox.TabIndex = 5;
            // 
            // applyform_applyjobButton
            // 
            this.applyform_applyjobButton.Location = new System.Drawing.Point(145, 137);
            this.applyform_applyjobButton.Name = "applyform_applyjobButton";
            this.applyform_applyjobButton.Size = new System.Drawing.Size(75, 23);
            this.applyform_applyjobButton.TabIndex = 6;
            this.applyform_applyjobButton.Text = "Apply";
            this.applyform_applyjobButton.UseVisualStyleBackColor = true;
            this.applyform_applyjobButton.Click += new System.EventHandler(this.applyform_applyjobButton_Click);
            // 
            // applyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 195);
            this.Controls.Add(this.applyform_applyjobButton);
            this.Controls.Add(this.applyform_paymentTextBox);
            this.Controls.Add(this.applyform_handymanIDtextbox);
            this.Controls.Add(this.applyform_jobidTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "applyform";
            this.Text = "applyform";
            this.Load += new System.EventHandler(this.applyform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox applyform_jobidTextBox;
        private System.Windows.Forms.TextBox applyform_handymanIDtextbox;
        private System.Windows.Forms.TextBox applyform_paymentTextBox;
        private System.Windows.Forms.Button applyform_applyjobButton;
    }
}