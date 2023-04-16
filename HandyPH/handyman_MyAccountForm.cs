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
        }
    }
}
