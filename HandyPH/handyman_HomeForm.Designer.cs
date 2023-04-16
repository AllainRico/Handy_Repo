namespace HandyPH
{
    partial class handyman_HomeForm
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
            this.handymanhome_myaccountbutton = new System.Windows.Forms.Button();
            this.alljobs_datagridview = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.handymanhome_ApplyButton = new System.Windows.Forms.Button();
            this.handymanhome_jobdescriptionButton = new System.Windows.Forms.TextBox();
            this.handymanhome_datepostedButton = new System.Windows.Forms.TextBox();
            this.handymanhome_timeframeButton = new System.Windows.Forms.TextBox();
            this.handymanhome_basepayButton = new System.Windows.Forms.TextBox();
            this.handymanhome_postedbyTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alljobs_datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // handymanhome_myaccountbutton
            // 
            this.handymanhome_myaccountbutton.Location = new System.Drawing.Point(758, 12);
            this.handymanhome_myaccountbutton.Name = "handymanhome_myaccountbutton";
            this.handymanhome_myaccountbutton.Size = new System.Drawing.Size(100, 35);
            this.handymanhome_myaccountbutton.TabIndex = 0;
            this.handymanhome_myaccountbutton.Text = "My Account";
            this.handymanhome_myaccountbutton.UseVisualStyleBackColor = true;
            this.handymanhome_myaccountbutton.Click += new System.EventHandler(this.handymanhome_myaccountbutton_Click);
            // 
            // alljobs_datagridview
            // 
            this.alljobs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alljobs_datagridview.Location = new System.Drawing.Point(23, 99);
            this.alljobs_datagridview.Name = "alljobs_datagridview";
            this.alljobs_datagridview.ReadOnly = true;
            this.alljobs_datagridview.Size = new System.Drawing.Size(637, 365);
            this.alljobs_datagridview.TabIndex = 1;
            this.alljobs_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alljobs_datagridview_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.handymanhome_ApplyButton);
            this.groupBox1.Controls.Add(this.handymanhome_jobdescriptionButton);
            this.groupBox1.Controls.Add(this.handymanhome_datepostedButton);
            this.groupBox1.Controls.Add(this.handymanhome_timeframeButton);
            this.groupBox1.Controls.Add(this.handymanhome_basepayButton);
            this.groupBox1.Controls.Add(this.handymanhome_postedbyTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(680, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // handymanhome_ApplyButton
            // 
            this.handymanhome_ApplyButton.Location = new System.Drawing.Point(132, 290);
            this.handymanhome_ApplyButton.Name = "handymanhome_ApplyButton";
            this.handymanhome_ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.handymanhome_ApplyButton.TabIndex = 10;
            this.handymanhome_ApplyButton.Text = "Apply";
            this.handymanhome_ApplyButton.UseVisualStyleBackColor = true;
            this.handymanhome_ApplyButton.Click += new System.EventHandler(this.handymanhome_ApplyButton_Click);
            // 
            // handymanhome_jobdescriptionButton
            // 
            this.handymanhome_jobdescriptionButton.Enabled = false;
            this.handymanhome_jobdescriptionButton.Location = new System.Drawing.Point(10, 170);
            this.handymanhome_jobdescriptionButton.Multiline = true;
            this.handymanhome_jobdescriptionButton.Name = "handymanhome_jobdescriptionButton";
            this.handymanhome_jobdescriptionButton.ReadOnly = true;
            this.handymanhome_jobdescriptionButton.Size = new System.Drawing.Size(202, 114);
            this.handymanhome_jobdescriptionButton.TabIndex = 9;
            // 
            // handymanhome_datepostedButton
            // 
            this.handymanhome_datepostedButton.Enabled = false;
            this.handymanhome_datepostedButton.Location = new System.Drawing.Point(87, 118);
            this.handymanhome_datepostedButton.Name = "handymanhome_datepostedButton";
            this.handymanhome_datepostedButton.ReadOnly = true;
            this.handymanhome_datepostedButton.Size = new System.Drawing.Size(125, 20);
            this.handymanhome_datepostedButton.TabIndex = 8;
            // 
            // handymanhome_timeframeButton
            // 
            this.handymanhome_timeframeButton.Enabled = false;
            this.handymanhome_timeframeButton.Location = new System.Drawing.Point(87, 85);
            this.handymanhome_timeframeButton.Name = "handymanhome_timeframeButton";
            this.handymanhome_timeframeButton.ReadOnly = true;
            this.handymanhome_timeframeButton.Size = new System.Drawing.Size(125, 20);
            this.handymanhome_timeframeButton.TabIndex = 7;
            // 
            // handymanhome_basepayButton
            // 
            this.handymanhome_basepayButton.Enabled = false;
            this.handymanhome_basepayButton.Location = new System.Drawing.Point(87, 50);
            this.handymanhome_basepayButton.Name = "handymanhome_basepayButton";
            this.handymanhome_basepayButton.ReadOnly = true;
            this.handymanhome_basepayButton.Size = new System.Drawing.Size(125, 20);
            this.handymanhome_basepayButton.TabIndex = 6;
            // 
            // handymanhome_postedbyTextbox
            // 
            this.handymanhome_postedbyTextbox.Enabled = false;
            this.handymanhome_postedbyTextbox.Location = new System.Drawing.Point(87, 17);
            this.handymanhome_postedbyTextbox.Name = "handymanhome_postedbyTextbox";
            this.handymanhome_postedbyTextbox.ReadOnly = true;
            this.handymanhome_postedbyTextbox.Size = new System.Drawing.Size(125, 20);
            this.handymanhome_postedbyTextbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Job Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Posted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Posted By";
            // 
            // handyman_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.alljobs_datagridview);
            this.Controls.Add(this.handymanhome_myaccountbutton);
            this.Name = "handyman_HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.handyman_HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alljobs_datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button handymanhome_myaccountbutton;
        private System.Windows.Forms.DataGridView alljobs_datagridview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox handymanhome_jobdescriptionButton;
        private System.Windows.Forms.TextBox handymanhome_datepostedButton;
        private System.Windows.Forms.TextBox handymanhome_timeframeButton;
        private System.Windows.Forms.TextBox handymanhome_basepayButton;
        private System.Windows.Forms.TextBox handymanhome_postedbyTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button handymanhome_ApplyButton;
    }
}