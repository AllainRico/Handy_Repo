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
    public partial class homeowner_HomeForm : Form
    {
        public string homeownerhome_username;
        public homeowner_HomeForm()
        {
            InitializeComponent();
        }

        private void homeowner_HomeForm_Load(object sender, EventArgs e)
        {
            //textBox1.Text= homeownerhome_username;
            int ID;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT homeowner_ID FROM[dbo].[tblHomeowners] where username = '" + this.homeownerhome_username + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                // Extract the integer value from the first row and store it in the ID variable
                ID = Convert.ToInt32(dtbl.Rows[0]["homeowner_ID"]);
                textBox1.Text = Convert.ToString(ID);
            }
            else
            {
                MessageBox.Show("ERROR! ID NOT FOUND!");
            }

            //here is for loading the shitty dtgridview

            SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * FROM[dbo].[tblCreateJob] where homeowner_ID = " + textBox1.Text + "", con);
            DataTable dtbl2 = new DataTable();
            sqlData2.Fill(dtbl2);

            dataGridView1.DataSource = dtbl2;
        }

        private void homeownerhome_myaccountbutton_Click(object sender, EventArgs e)
        {
            homeowner_MyAccountForm myaccount = new homeowner_MyAccountForm();
            myaccount.homeowner_username = this.homeownerhome_username;
            myaccount.Show();
            this.Hide();
        }

        private void postjobbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into [dbo].[tblCreateJob] VALUES ('" + textBox1.Text + "', '" + textBox4.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', GETDATE());", con);
                cmd.ExecuteNonQuery();

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                MessageBox.Show("Job posted successfully", "Success");

                SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT * FROM[dbo].[tblCreateJob] where homeowner_ID = " + textBox1.Text + "", con);
                DataTable dtbl2 = new DataTable();
                sqlData2.Fill(dtbl2);

                dataGridView1.DataSource = dtbl2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginForm logout = new loginForm();
            logout.Show();
            this.Hide();
        }
    }
}
