﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSheet
{
    public partial class AddUserPage : Form
    {
        public AddUserPage()
        {
            InitializeComponent();
            UserType.Items.Add("Admin");
            UserType.Items.Add("User");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
