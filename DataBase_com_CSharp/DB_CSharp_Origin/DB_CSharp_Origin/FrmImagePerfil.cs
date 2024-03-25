using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DB_CSharp_Origin
{
    public partial class FrmImagePerfil : Form
    {

        bool visiblepasswordchar;
        ClConnection conn = new ClConnection();
        String Cam_FT = "";

        public FrmImagePerfil()
        {
            InitializeComponent();
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Controls.Add(hm.GetMenu());
            PBvisible.Image = listImage_Visible_password.Images[0];
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (visiblepasswordchar)
            {
                visiblepasswordchar = false;
                textpassword.PasswordChar = '•';
                PBvisible.Image = listImage_Visible_password.Images[0];
            }
            else
            {
                visiblepasswordchar = true;
                textpassword.PasswordChar = '\0';
                PBvisible.Image = listImage_Visible_password.Images[1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ft_perfil = new OpenFileDialog();
                ft_perfil.Filter = "(*.jpg; *.gif; *.png; *.jpeg)|*.jpg; *.gif; *.png; *.jpeg";
                if (ft_perfil.ShowDialog() == DialogResult.OK)
                {
                    Image files = FromFile(ft_perfil.FileName);
                    Cam_FT = ft_perfil.FileName;
                    PBrouder_perfil.Image = files;
                    PBrouder_perfil.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                else
                {
                    MessageBox.Show("Nenhuma Imagem Selecionada!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private Image FromFile(string fileName)
        {
            return Image.FromFile(fileName);
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

        private void FrmImagePerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PBrouder_perfil_Click(object sender, EventArgs e)
        {

        }
    }
}
