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
    public partial class updateInfo_HandymanForm : Form
    {
        public string username;
        public updateInfo_HandymanForm()
        {
            InitializeComponent();
        }

        private void saveinfobutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
             con.Open();
            String st = "INSERT INTO [dbo].[tblHandyman] values (@username, @firstname, @lastname, @contactnumber, @municipality, @city, @barangay, @street, @expertfield, @about)";
            SqlCommand cmd1 = new SqlCommand(st, con);
            cmd1.Parameters.AddWithValue("@username", usernameText.Text);
            cmd1.Parameters.AddWithValue("@firstname", FirstnameText.Text);
            cmd1.Parameters.AddWithValue("@lastname", LastnameText.Text);
            cmd1.Parameters.AddWithValue("@contactnumber", contactText.Text);
            cmd1.Parameters.AddWithValue("@municipality", Municipalitytext.Text);
            cmd1.Parameters.AddWithValue("@city", CityText.Text);
            cmd1.Parameters.AddWithValue("@barangay", BarangayText.Text);
            cmd1.Parameters.AddWithValue("@street", StreetText.Text);
            cmd1.Parameters.AddWithValue("@expertfield", ExpertFieldText.Text);
            cmd1.Parameters.AddWithValue("@about", AboutText.Text);
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Information updated successfully!", "Successful!");

            this.Hide();
            handyman_HomeForm home = new handyman_HomeForm();
            home.handyhome_username = usernameText.Text;
            home.Show();
        }

        private void updateInfo_HandymanForm_Load(object sender, EventArgs e)
        {
            usernameText.Text = username;
        }
    }
}
