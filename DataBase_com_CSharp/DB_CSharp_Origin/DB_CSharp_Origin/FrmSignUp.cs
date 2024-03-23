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
        ClConnection conn = new ClConnection();
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            PBvisiblePassword.Image = listImage_Visible_password.Images[0];
            int ano_atual = DateTime.Now.Year;
            for (int i = ano_atual; i > ano_atual - 100; i--)
            {
                CBano.Items.Add(i);
            }
            for (int i = 0; i < 31; i++)
            {
                CBdia.Items.Add(i + 1);
            }
            for (int i = 0; i < 12; i++)
            {
                CBmes.Items.Add(i + 1);
            }


            CBperfil.DataSource = conn.Obter_dados("select * from perfil;");
            CBperfil.DisplayMember = "Cargo";
            CBperfil.ValueMember = "Cod_perfil";
            CBperfil.Text = String.Empty;


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

        private void signup_Click(object sender, EventArgs e)
        {
            if (conn.SignUp(textName, textuser, textpassword, CBperfil, CBdia, CBmes, CBano) > 0)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!!!!");
                MessageBox.Show("Com o Cadastro Feito, agora será direcionado para a aba de Log In");
                FrmLogIn logIn = new FrmLogIn();
                this.Hide();
                logIn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cadastro Negado");

            }
        }


    }
}
