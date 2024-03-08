using MySql.Data.MySqlClient;

namespace DataBase_com_CSharp
{
    public partial class FrmUser : Form
    {


        public FrmUser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                clconnection clc = new clconnection();
                clc.cadastrar(textname, textidade, textano, textuser, textpassword);



                FrmProduto prof = new FrmProduto();
                this.Hide();
                prof.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }

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

        private void FrmUser_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
