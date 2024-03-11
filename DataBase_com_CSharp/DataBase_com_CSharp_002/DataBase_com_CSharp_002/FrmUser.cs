namespace DataBase_com_CSharp_002
{
    public partial class FrmUser : Form
    {
        clconnection Conn = new clconnection();
        public FrmUser()
        {
            InitializeComponent();
        }




        private void FrmUser_Load(object sender, EventArgs e)
        {
            Int32 anoatual = DateTime.Now.Year;
            for (int i = 0; i < 101; i++)
            {
                CBAno.Items.Add(anoatual - i);
            }
            this.Controls.Add(CBAno);
            for (int i = 0; i < 12; i++)
            {
                CBMes.Items.Add(i + 1);
            }
            for (int i = 0; i < 31; i++)
            {
                CBDia.Items.Add(i + 1);
            }

        }

        private void Teste_Click(object sender, EventArgs e)
        {
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Conn.Cadastrar(txtNome, textIdade, CBAno, CBMes, CBDia, textUser, textPassWord) > 0)
            {
                MessageBox.Show("Cadastro OK");
            }
            else
            {
                MessageBox.Show("Não foi possivel");
            }

            FrmProduto prod = new FrmProduto();
            this.Hide();
            prod.ShowDialog();

        }
    }
}
