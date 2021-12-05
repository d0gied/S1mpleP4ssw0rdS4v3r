using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dvfuApp.Resources
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            gridPasswords.ColumnCount = 3;
            gridPasswords.Columns[0].Name = "Title";
            gridPasswords.Columns[1].Name = "Username";
            gridPasswords.Columns[2].Name = "Password Encrypted";
            string data = Properties.Settings.Default.gridData;
            if(data != "")
                foreach (var row in data.Split('\x0001'))
                {
                    gridPasswords.Rows.Add(row.Split('\x0002'));
                }
        }
            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string Encrypt(string Username, string Password)
        {
            var encoded_password = UTF8Encoding.UTF8.GetBytes(Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(Password)));
            for (int i = 0; i < encoded_password.Length; i++)
            {
   
                if (i % 2 == 0)
                {
                    var tmp = encoded_password[i];
                    encoded_password[i] = encoded_password[encoded_password.Length - i - 1];
                    encoded_password[encoded_password.Length - i - 1] = tmp;
                }
                else
                {
                    encoded_password[i] = (byte)(((encoded_password[i] - 33) + (Username[i % Username.Length] - 33)) % 93 + 33);
                }
            }
            return UTF8Encoding.UTF8.GetString(encoded_password);
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Resources.dialogAddRow();
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string encryptedPassword = Encrypt(dialog.Username, dialog.Password);
                gridPasswords.Rows.Add(new string[]{ dialog.Title, dialog.Username, encryptedPassword});
                if(Properties.Settings.Default.gridData != "")
                    Properties.Settings.Default.gridData += "\x0001";
                Properties.Settings.Default.gridData += $"{dialog.Title}\x0002{dialog.Username}\x0002{encryptedPassword}";
                Properties.Settings.Default.Save();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S1mpleP4sswordS4ver\nGithub: github.com/...");
        }
    }
}
