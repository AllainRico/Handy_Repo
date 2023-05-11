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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void signupform_signupButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=DESKTOP-S8N66SD\SQLEXPRESS;Initial Catalog=handymandb;Integrated Security=True");
            //change this shit kay ma error ni 

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tblUsers where username='" + signupform_usernametextBox.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //requirements for password!!! (Still subject for revision)
            //1>must be > 8
            //2>must have uppercase

            if (dt.Rows.Count == 0) //checks if name is already taken
            {
                if (signupform_usernametextBox.Text == "" || signupform_passwordtextBox.Text == "") //if fields are empty
                {
                    MessageBox.Show("Fields are empty!", "ERROR: 1");
                }
                else
                {
                    if (signupform_passwordtextBox.TextLength < 7)
                    {
                        MessageBox.Show("Password length is lesser than 8", "ERROR: 2");
                    }
                    else
                    {
                        if (signupform_confirmpasswordtextBox.Text != signupform_passwordtextBox.Text)
                        {
                            MessageBox.Show("password does not match", "ERROR: 3");
                        }
                        else
                        {
                            bool hasUpperCase = false;
                            bool hasLowerCase = false;

                            foreach (char c in signupform_passwordtextBox.Text)
                            {
                                if (char.IsUpper(c))
                                {
                                    hasUpperCase = true;
                                }
                                else if (char.IsLower(c))
                                {
                                    hasLowerCase = true;
                                }
                            }
                            if (hasUpperCase && hasLowerCase)
                            {
                                string encpass = encrypt.Encrypt(signupform_passwordtextBox.Text);
                                //string encpass = signupform_passwordtextBox.Text;

                                String st = "INSERT INTO tblUsers(username,password) values (@username, @password)";
                                SqlCommand cmd1 = new SqlCommand(st, con);
                                cmd1.Parameters.AddWithValue("@username", signupform_usernametextBox.Text);
                                cmd1.Parameters.AddWithValue("@password", encpass);
                                cmd1.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Account created successfully! - Please input credentials in the Login Form", "Successful!");

                                this.Hide();
                                userHome step2 = new userHome();
                                step2.username = signupform_usernametextBox.Text;
                                step2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password does not have an uppercase", "ERROR: 4");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username already taken", "ERROR: 0");
            }

        }
    }
}
