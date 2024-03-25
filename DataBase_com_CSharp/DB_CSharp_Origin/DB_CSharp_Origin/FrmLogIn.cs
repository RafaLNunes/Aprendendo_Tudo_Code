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
        ClConnection conn = new ClConnection();
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

        private void Test_Connection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (conn.GetConnection != null)
                {
                    MessageBox.Show("Conexão Estabelecida com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Conexão Não foiEstabelecida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT_logIn = conn.LogIn(textUser, textpassword);

            MessageBox.Show($"ID Logado: {DT_logIn.Rows[0][1].ToString()}\nUser Name: {DT_logIn.Rows[0][5].ToString()}\nIdade: {DT_logIn.Rows[0][2].ToString()}");

            if (Convert.ToInt32(DT_logIn.Rows[0][0]) > 0)
            {
                this.Hide();
                FrmAlter n = new FrmAlter();
                MessageBox.Show($"Seja bem vindo {DT_logIn.Rows[0][1].ToString()}");
                n.ShowDialog();
            }

        }
    }
}
