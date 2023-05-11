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

        public String TextToPass { get; set; }

        public loginForm()
        {
            InitializeComponent();

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string encpass = encrypt.Encrypt(login_passwordtextBox.Text);
            string decryptedPassword = encrypt.Decrypt(encpass);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            //change this shit kay ma error ni bai

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUsers where username='" + login_usernametextBox.Text + "'", con);
            cmd.Parameters.AddWithValue("@username", login_usernametextBox.Text);
            cmd.Parameters.AddWithValue("@password", decryptedPassword);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            if (dt.Rows.Count > 0)
            {
                string accountType = dt.Rows[0]["username"].ToString();
                if (accountType == "ADMIN")
                {
                    String username = TextToPass;
                    MessageBox.Show("Welcome admin");
                    adminHome home = new adminHome();
                    home.Show();
                    Visible = false;
                }
                else
                {
                    String username = login_usernametextBox.Text;
                    MessageBox.Show("Welcome user");
                    handyman_HomeForm handyman_home = new handyman_HomeForm();
                    //Borrow form2 = new Borrow();
                    //home.usernametext.Text = usernameTextBox.Text;

                    handyman_home.handyhome_username = username;
                    handyman_home.Show();
                    Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect credentials!", "ERROR: login_error");
            }
        }

        private void loginform_signupbutton_Click(object sender, EventArgs e)
        {
            signupForm signup = new signupForm();
            signup.Show();
            this.Hide();
        }
    }
}
