using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_com_CSharp_002
{
    public partial class FrmProduto : Form
    {

        String Cam_FT = "";
        clconnection cot = new clconnection();
        DataTable car;

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Frmteste teste = new Frmteste();
            teste.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ft = new OpenFileDialog();
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ft.FileName);
                    Cam_FT = ft.FileName.Replace("\\", "\\\\");

                }
                else
                {
                    MessageBox.Show("Não foi escolhido nenhuma imagem!!!");
                }

            }
            catch (Exception xe)
            {
                MessageBox.Show("Erro: " + xe.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clproduto prod = new Clproduto();
            prod.foto = Cam_FT;
            prod.nome = textprod.Text;
            prod.preco = float.Parse(textpreco.Text);
            prod.fornecedor = Convert.ToInt32(textfornc.Text);
            prod.qtd_prod = Convert.ToInt32(textqtd.Text);

            prod.Cadastrar(prod);
        }

        private void CBprod_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }
    }
}
