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
    public partial class handyman_MyAccountForm : Form
    {
        public string handyman_username;
        public handyman_MyAccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void handyman_MyAccountForm_Load(object sender, EventArgs e)
        {
            handymanmyaccountform_usernameTextBox.Text = handyman_username;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S8N66SD\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select [firstname], [lastname], [contactnumber], [municipality], [city], [barangay],[street],[expertfield],[about] from tblHandyman where username = '" + handymanmyaccountform_usernameTextBox.Text + "';", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                handymanmyaccountform_firstnameTextBox.Text = da.GetValue(0).ToString();
                handymanmyaccountform_lastnameTextBox.Text = da.GetValue(1).ToString();
                handymanmyaccountform_contactnumberTextBox.Text = da.GetValue(2).ToString();
                handymanmyaccountform_municipalityTextBox.Text = da.GetValue(3).ToString();
                handymanmyaccountform_cityTextBox.Text = da.GetValue(4).ToString();
                handymanmyaccountform_barangayTextBox.Text = da.GetValue(5).ToString();
                handymanmyaccountform_streetTextBox.Text = da.GetValue(6).ToString();
                handymanmyaccountform_expertfieldCombo.Text = da.GetValue(7).ToString();
                handymanmyaccountform_aboutTextBox.Text = da.GetValue(8).ToString();
            }
        }
    }
}
