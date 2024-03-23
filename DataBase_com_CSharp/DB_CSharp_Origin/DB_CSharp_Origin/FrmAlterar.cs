using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmAlterar : Form
    {
        bool passwordchard;
        ClConnection conn = new ClConnection();

        DataTable logIn;

        public FrmAlterar(DataTable User)
        {
            this.logIn = User;

            InitializeComponent();
            MessageBox.Show($"Seja bem vindo {this.logIn.Rows[0][1].ToString()}");
        }
        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            PBvisiblePassword.Image = listImage_Visible_password.Images[0];

            dataGridViewuser.DataSource = conn.Obter_dados("select Users.Cod_User as 'Código', Users.Nome as 'Nome', Users.idade as 'Idade', Users.Data_nasc as 'Ano de cadastro', Users.UserName as 'Name User',  Users.Passwords as 'PassWord', perfil.Cargo as 'Perfil do Usuário' from users inner join perfil on users.CFK_perfil = perfil.Cod_perfil;");
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

        private void FrmAlterar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridViewuser.DataSource = conn.Obter_dados("select Users.Cod_User as 'Código', Users.Nome as 'Nome', Users.idade as 'Idade', Users.Data_nasc as 'Ano de cadastro', Users.UserName as 'Name User',  Users.Passwords as 'PassWord', perfil.Cargo as 'Perfil do Usuário' from users inner join perfil on users.CFK_perfil = perfil.Cod_perfil;");
            MessageBox.Show("Atualizado!!!");
        }
    }
}
