namespace DataBase_com_CSharp_002
{
    public partial class FrmUser : Form
    {
        clconnection Conn = new clconnection();
        public FrmUser()
        {
            InitializeComponent();
        }

        Int32 anoatual = DateTime.Now.Year;
        

        private void FrmUser_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                CBAno.Items.Add(anoatual-i);
            }
            this.Controls.Add(CBAno);
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
            catch(Exception ex)
            {
                MessageBox.Show($"Erro em: {ex.Message}");
            }
        }
    }
}
