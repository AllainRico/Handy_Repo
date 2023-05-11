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
    public partial class homeowner_MyAccountForm : Form
    {
        public string homeowner_username;
        public homeowner_MyAccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void homeowner_MyAccountForm_Load(object sender, EventArgs e)
        {
            homeownermyaccountform_usernameTextBox.Text = homeowner_username;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select [firstname], [lastname], [contactnumber], [municipality], [city], [barangay],[street] from [dbo].[tblHomeowners] where username = '" + homeownermyaccountform_usernameTextBox.Text + "';", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                homeownermyaccountform_firstnameTextBox.Text = da.GetValue(0).ToString();
                homeownermyaccountform_lastnameTextBox.Text = da.GetValue(1).ToString();
                homeownermyaccountform_contactnumberTextBox.Text = da.GetValue(2).ToString();
                homeownermyaccountform_municipalityTextBox.Text = da.GetValue(3).ToString();
                homeownermyaccountform_cityTextBox.Text = da.GetValue(4).ToString();
                homeownermyaccountform_barangayTextBox.Text = da.GetValue(5).ToString();
                homeownermyaccountform_streetTextBox.Text = da.GetValue(6).ToString();
            }
        }
    }
}
