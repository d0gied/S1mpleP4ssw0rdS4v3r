using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dvfuApp.Resources
{
    public partial class dialogAddRow : Form
    {
        public string Title;
        public string Username;
        public string Password;
        public dialogAddRow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
            Password = tbPassword.Text;
            Username = tbUsername.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
