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
    }
}
