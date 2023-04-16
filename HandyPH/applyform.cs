using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HandyPH
{
    
    public partial class applyform : Form
    {
        public int handyman_ID, job_ID;
        public float payment;
        public applyform()
        {
            InitializeComponent();
        }

        public string TextToPass { get; set; }

        private void applyform_Load(object sender, EventArgs e)
        {
            applyform_handymanIDtextbox.Text = handyman_ID.ToString();
            applyform_jobidTextBox.Text = job_ID.ToString();
        }

        private void applyform_applyjobButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into tblApplyJob VALUES ('"+ applyform_jobidTextBox.Text + "', '" + applyform_handymanIDtextbox.Text + "', '"+ applyform_paymentTextBox.Text + "', GETDATE());", con);
            cmd.ExecuteNonQuery();

            applyform_paymentTextBox.Clear();
            MessageBox.Show("Application sent successfully", "Success");
        }

       
    }
}
