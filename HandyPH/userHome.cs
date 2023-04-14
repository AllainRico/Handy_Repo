using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandyPH
{
    public partial class userHome : Form
    {
        public userHome()
        {
            InitializeComponent();
        }

        private void userhome_handymanbutton_Click(object sender, EventArgs e)
        {
            handyman_HomeForm handyman = new handyman_HomeForm();
            handyman.Show();
            this.Hide();
        }

        private void userhome_homeownerbutton_Click(object sender, EventArgs e)
        {
            homeowner_HomeForm homeowner = new homeowner_HomeForm();
            homeowner.Show();
            this.Hide();
        }
    }
}
