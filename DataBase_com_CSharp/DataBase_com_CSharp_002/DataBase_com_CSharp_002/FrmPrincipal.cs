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
    public partial class FrmPrincipal : Form
    {

        DataTable logIn;

        public FrmPrincipal(DataTable user)
        {

            this.logIn = user;
            InitializeComponent();

            MessageBox.Show($"Seja bem vindo {this.logIn.Rows[0][1].ToString()}");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
