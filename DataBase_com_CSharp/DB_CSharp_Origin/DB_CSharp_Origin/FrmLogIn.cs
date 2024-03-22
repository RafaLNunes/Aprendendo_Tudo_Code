using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CSharp_Origin
{
    public partial class FrmLogIn : Form
    {
        bool passwordchard;
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            PBvisiblePassword.Image = listImage_Visible_password.Images[0];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp signup = new FrmSignUp();
            this.Hide();
            signup.ShowDialog();
        }

        private void PBvisiblePassword_Click(object sender, EventArgs e)
        {
            if (passwordchard)
            {
                passwordchard = false;
                textpassword.PasswordChar = '•';
                PBvisiblePassword.Image = listImage_Visible_password.Images[0];
            }
            else
            {
                passwordchard = true;
                textpassword.PasswordChar = '\0';
                PBvisiblePassword.Image = listImage_Visible_password.Images[1];

            }
        }

        private void FrmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
