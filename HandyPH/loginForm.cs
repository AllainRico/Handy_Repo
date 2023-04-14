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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            //change this shit kay ma error ni bai

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUsers where username='" + login_usernametextBox.Text + "' and password = '" + login_passwordtextBox.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            if (dt.Rows.Count > 0)
            {

                if (login_usernametextBox.Text == "admin")
                {
                    MessageBox.Show("Welcome admin");
                    adminHome home = new adminHome();
                    home.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Welcome user");
                    userHome home = new userHome();
                    //Borrow form2 = new Borrow();
                    //home.usernametext.Text = usernameTextBox.Text;
                    home.Show();
                    Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect credentials!", "ERROR: login_error");
            }
        }
    }
}
