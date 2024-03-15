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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
            ir_cad.Visible = false;
        }

        private void FrmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            cluser u = new cluser();

            DataTable cod = u.log(textuser, textpass);

            MessageBox.Show($"Id logado: {cod.Rows[0][1].ToString()}");

            if (Convert.ToInt32(cod.Rows[0][0]) > 0)
            {
                this.Hide();
                FrmPrincipal n = new FrmPrincipal(cod);
                n.ShowDialog();

            }

        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clconnection Conn = new clconnection();
            try
            {
                if (Conn.TestConnection == null)
                {
                    MessageBox.Show("Conexão não foi feita");
                }
                else
                {
                    MessageBox.Show("Conexão bem sucedida!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textpass.Text = String.Empty;
            textuser.Text = String.Empty;



            ir_cad.Visible = true;


        }

        private void ir_cad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmuser frmuser = new Frmuser();
            frmuser.ShowDialog();
        }
    }
}
