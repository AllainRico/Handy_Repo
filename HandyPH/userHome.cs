using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandyPH
{
    public partial class userHome : Form
    {
        public string username;
        public userHome()
        {
            InitializeComponent();

        }

        private void userhome_handymanbutton_Click(object sender, EventArgs e)
        {
            updateInfo_HandymanForm step3 = new updateInfo_HandymanForm();
            step3.username = textBox1.Text;
            step3.Show();
            this.Hide();
        }

        private void userhome_homeownerbutton_Click(object sender, EventArgs e)
        {
            updateInfo_HomeownerForm homeowner = new updateInfo_HomeownerForm();
            homeowner.username = textBox1.Text;
            homeowner.Show();
            this.Hide();
        }

        private void userHome_Load(object sender, EventArgs e)
        {
            textBox1.Text = username;
        }
    }

}
