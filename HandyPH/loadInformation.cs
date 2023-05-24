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
    public partial class loadInformation : Form
    {
        public String handyid;
        public loadInformation()
        {
            InitializeComponent();
        }

        private void loadInformation_Load(object sender, EventArgs e)
        {
            textBox1.Text = handyid;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            con.Open();

            string query = "SELECT [firstname], [lastname], [contactnumber], [municipality], [city], [barangay], [street], [expertfield], [about] FROM [dbo].[tblHandyman] WHERE handyman_ID = '" + handyid + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                textBox2.Text = da.GetValue(0).ToString();
                textBox3.Text = da.GetValue(1).ToString();
                textBox4.Text = da.GetValue(2).ToString();
                textBox5.Text = da.GetValue(3).ToString();
                textBox6.Text = da.GetValue(4).ToString();
                textBox7.Text = da.GetValue(5).ToString();
                textBox8.Text = da.GetValue(6).ToString();
                textBox9.Text = da.GetValue(7).ToString();
            }

        }
    }
}
