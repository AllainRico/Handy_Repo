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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HandyPH
{
    public partial class handyman_HomeForm : Form
    {
        public string handyhome_username;
        public string job_ID;
        public String TextToPass { get; set; }

        public handyman_HomeForm()
        {
            InitializeComponent();
            

        }

        private void handymanhome_myaccountbutton_Click(object sender, EventArgs e)
        {
            handyman_MyAccountForm myaccount = new handyman_MyAccountForm();
            myaccount.handyman_username = usernametxtbox.Text;
            myaccount.Show();
            //this.Hide();
        }

        private void handyman_HomeForm_Load(object sender, EventArgs e)
        {
            usernametxtbox.Text = handyhome_username;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            //sayop ni earl. dapat ang makita kay joblisting
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM[dbo].[tblCreateJob]", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

            //this.alljobs_datagridview(this.libsysdbDataSet.booksTable)
        }

        private void alljobs_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                job_IDtxtbox.Text = row.Cells["job_ID"].Value.ToString();
                handymanhome_postedbyTextbox.Text = row.Cells["homeowner_ID"].Value.ToString();
                handymanhome_basepayButton.Text = row.Cells["basepay"].Value.ToString();
                handymanhome_timeframeButton.Text = row.Cells["timeframe"].Value.ToString();
                handymanhome_datepostedButton.Text = row.Cells["dateposted"].Value.ToString();
                handymanhome_jobdescriptionButton.Text = row.Cells["job_description"].Value.ToString();
            }
        }

        private void handymanhome_ApplyButton_Click(object sender, EventArgs e)
        {
            //int ID;
            int ID;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT handyman_ID FROM[dbo].[tblHandyman] where username = '"+ this.handyhome_username +"'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            
            if (dtbl.Rows.Count > 0)
            {
                // Extract the integer value from the first row and store it in the ID variable
                ID = Convert.ToInt32(dtbl.Rows[0]["handyman_ID"]);
                applyform apply = new applyform();
                apply.handyman_ID = ID;
                apply.job_ID = job_IDtxtbox.Text;

                apply.Show();
            }
            
        }

        private void handymanhome_myaccountbutton_Click_1(object sender, EventArgs e)
        {
            handyman_MyAccountForm myacc = new handyman_MyAccountForm();
            myacc.handyman_username = usernametxtbox.Text;
            myacc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm logout = new loginForm();
            logout.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                job_IDtxtbox.Text = row.Cells["job_ID"].Value.ToString();
                handymanhome_postedbyTextbox.Text = row.Cells["homeowner_ID"].Value.ToString();
                handymanhome_basepayButton.Text = row.Cells["basepay"].Value.ToString();
                handymanhome_timeframeButton.Text = row.Cells["timeframe"].Value.ToString();
                handymanhome_datepostedButton.Text = row.Cells["dateposted"].Value.ToString();
                handymanhome_jobdescriptionButton.Text = row.Cells["job_description"].Value.ToString();
            }
        }
    }
}
