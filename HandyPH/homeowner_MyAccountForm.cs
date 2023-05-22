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

        private void btnHome_Click(object sender, EventArgs e)
        {
            String username = homeownermyaccountform_usernameTextBox.Text;
            homeowner_HomeForm homeowner_home = new homeowner_HomeForm();
            //Borrow form2 = new Borrow();
            //home.usernametext.Text = usernameTextBox.Text;

            homeowner_home.homeownerhome_username = username;
            homeowner_home.Show();
            this.Hide();
        }

        private void myaccountform_editmyaccountButton_Click(object sender, EventArgs e)
        {
            //ToolTip toolTip = new ToolTip();
            //toolTip.Show("editing enabled", editAccountbtn, 0, 0, 2000);
            //MessageBox.Show("Editing Enabled! Please specify changes","Update Information");


            homeownermyaccountform_contactnumberTextBox.Enabled = true;
            homeownermyaccountform_contactnumberTextBox.ReadOnly = false;

            homeownermyaccountform_municipalityTextBox.Enabled = true;
            homeownermyaccountform_municipalityTextBox.ReadOnly = false;

            homeownermyaccountform_cityTextBox.Enabled = true;
            homeownermyaccountform_cityTextBox.ReadOnly = false;

            homeownermyaccountform_barangayTextBox.Enabled = true;
            homeownermyaccountform_barangayTextBox.ReadOnly = false;

            homeownermyaccountform_streetTextBox.Enabled = true;
            homeownermyaccountform_streetTextBox.ReadOnly = false;

            editAccountbtn.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginForm logout = new loginForm();
            logout.Show();
            this.Hide();
        }

        private void submiteditbtn_Click(object sender, EventArgs e)
        {
            homeownermyaccountform_contactnumberTextBox.Enabled = false;
            homeownermyaccountform_contactnumberTextBox.ReadOnly = true;

            homeownermyaccountform_municipalityTextBox.Enabled = false;
            homeownermyaccountform_municipalityTextBox.ReadOnly = true;

            homeownermyaccountform_cityTextBox.Enabled = false;
            homeownermyaccountform_cityTextBox.ReadOnly = true;

            homeownermyaccountform_barangayTextBox.Enabled = false;
            homeownermyaccountform_barangayTextBox.ReadOnly = true;

            homeownermyaccountform_streetTextBox.Enabled = false;
            homeownermyaccountform_streetTextBox.ReadOnly = true;

            String contactnumber = homeownermyaccountform_contactnumberTextBox.Text;
            String municipality = homeownermyaccountform_municipalityTextBox.Text;
            String city = homeownermyaccountform_cityTextBox.Text;
            String barangay = homeownermyaccountform_barangayTextBox.Text;
            String street = homeownermyaccountform_streetTextBox.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tblHomeowners] set [contactnumber] = '"+contactnumber+"', [municipality] = '"+municipality+"' , [city] = '"+city+"', [barangay] = '"+barangay+"',[street] = '"+street+"' where username = '" + homeownermyaccountform_usernameTextBox.Text + "';", con);
            cmd.ExecuteReader();
            //MessageBox.Show("Record Change Done Successfully!", "Update Done");
            editAccountbtn.Show();
        }
    }
}
