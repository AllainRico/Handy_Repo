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
            //String encpass = encrypt.Decrypt(login_passwordtextBox.Text);
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
                    String username = TextToPass;
                    MessageBox.Show("Welcome admin");
                    adminHome home = new adminHome();
                    home.Show();
                    Visible = false;
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("select * from tblHandyman where username='" + login_usernametextBox.Text + "'", con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);

                    if (dt2.Rows.Count > 0) //checks if username is inside the handyman table
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
                    else
                    {
                        String username = login_usernametextBox.Text;
                        MessageBox.Show("Welcome user");
                        homeowner_HomeForm homeowner_home = new homeowner_HomeForm();
                        //Borrow form2 = new Borrow();
                        //home.usernametext.Text = usernameTextBox.Text;

                        homeowner_home.homeownerhome_username = username;
                        homeowner_home.Show();
                        Visible = false;
                    }


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
