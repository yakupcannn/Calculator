using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure close this application?",
                      "Exit",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "admin" && txtPassword.Text == "1234")
            {
                timer1.Enabled = true;
                lblResult.Text = "Login is successful";
                lblResult2.Text = "";
                lblResult2.BackColor = Color.Transparent;
                lblResult.BackColor = Color.Green;
            }
            else if (txtUserId.Text == "")
            {
                lblResult.Text = "UserName cannot be empty.";
                lblResult.BackColor = Color.Red;
                if (txtPassword.Text == "")
                {
                    lblResult2.BackColor = Color.Red;
                    lblResult2.Text = "Password cannot be empty";
                }
            }
            else if (txtPassword.Text == "")
            {
                lblResult.Text = "Password cannot be empty.";
                lblResult2.Text = "";
                lblResult.BackColor = Color.Red;
            }
            else
            {
                lblResult.Text = "Incorrect UserName or Password";
                lblResult2.Text = "";
                lblResult.BackColor = Color.Red;
            }

        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 4)
            {
                timer1.Stop();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
