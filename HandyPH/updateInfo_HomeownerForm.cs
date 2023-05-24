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
    public partial class updateInfo_HomeownerForm : Form
    {
        public string username;
        public updateInfo_HomeownerForm()
        {
            InitializeComponent();
        }

        private void updateInfo_HomeownerForm_Load(object sender, EventArgs e)
        {
            usernameText.Text = username;
        }

        private void saveinfobutton_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO [dbo].[tblHomeowners] values (@username, @firstname, @lastname, @contactnumber, @municipality, @city, @barangay, @street)";
            SqlCommand cmd1 = new SqlCommand(st, con);
            cmd1.Parameters.AddWithValue("@username", usernameText.Text);
            cmd1.Parameters.AddWithValue("@firstname", FirstnameText.Text);
            cmd1.Parameters.AddWithValue("@lastname", LastnameText.Text);
            cmd1.Parameters.AddWithValue("@contactnumber", contactText.Text);
            cmd1.Parameters.AddWithValue("@municipality", Municipalitytext.Text);
            cmd1.Parameters.AddWithValue("@city", CityText.Text);
            cmd1.Parameters.AddWithValue("@barangay", BarangayText.Text);
            cmd1.Parameters.AddWithValue("@street", StreetText.Text);
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information updated successfully!", "Successful!");

            //this.Hide();
            //homeowner_HomeForm home = new homeowner_HomeForm();
            //home.homeownerhome_username = usernameText.Text;
            //home.Show();

            String username = usernameText.Text;
            MessageBox.Show("Welcome user");
            homeowner_HomeForm homeownerhome = new homeowner_HomeForm();
            //Borrow form2 = new Borrow();
            //home.usernametext.Text = usernameTextBox.Text;

            homeownerhome.homeownerhome_username = username;
            homeownerhome.Show();
            Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            userHome userHome = new userHome();
            userHome.Show();
            this.Hide();

        }
    }
}
