using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_com_CSharp
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void Enter_dados_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnConection_Click(object sender, EventArgs e)
        {
            clconnection clc = new clconnection();
            if (clc.GetConnection() == null)
            {
                MessageBox.Show("ERRRRRRRRRROOOOOOOOO");
            }
            else
            {
                MessageBox.Show("Conection OK");
            }
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
