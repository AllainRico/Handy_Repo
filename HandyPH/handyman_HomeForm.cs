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

namespace HandyPH
{
    public partial class handyman_HomeForm : Form
    {
        public handyman_HomeForm()
        {
            InitializeComponent();
        }

        private void handymanhome_myaccountbutton_Click(object sender, EventArgs e)
        {
            handyman_MyAccountForm myaccount = new handyman_MyAccountForm();
            myaccount.Show();
            //this.Hide();
        }

        private void handyman_HomeForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT* FROM[dbo].[tblCreateJob]", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            alljobs_datagridview.DataSource = dtbl;

            //this.alljobs_datagridview(this.libsysdbDataSet.booksTable)
        }

        private void alljobs_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.alljobs_datagridview.Rows[e.RowIndex];

                handymanhome_postedbyButton.Text = row.Cells["homeowner_ID"].Value.ToString();
                handymanhome_basepayButton.Text = row.Cells["basepay"].Value.ToString();
                handymanhome_timeframeButton.Text = row.Cells["timeframe"].Value.ToString();
                handymanhome_datepostedButton.Text = row.Cells["dateposted"].Value.ToString();
                handymanhome_jobdescriptionButton.Text = row.Cells["job_description"].Value.ToString();
            }
        }
    }
}
