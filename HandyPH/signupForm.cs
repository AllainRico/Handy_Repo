﻿using System;
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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void signupform_signupButton_Click(object sender, EventArgs e)
        {
            userHome userhome = new userHome();
            userhome.Show();
            this.Hide();
        }
    }
}
