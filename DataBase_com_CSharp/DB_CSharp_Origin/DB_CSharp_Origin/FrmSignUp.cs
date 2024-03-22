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
    public partial class FrmSignUp : Form
    {

        bool passwordchard;

        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            PBvisiblePassword.Image = listImage_Visible_password.Images[0];
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void FrmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
