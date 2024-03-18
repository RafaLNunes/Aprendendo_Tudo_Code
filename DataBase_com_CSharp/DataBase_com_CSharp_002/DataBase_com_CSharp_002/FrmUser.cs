namespace DataBase_com_CSharp_002
{
    public partial class Frmuser : Form
    {
        clconnection Conn = new clconnection();
        int cod;
        bool teste;

        public Frmuser()
        {
            InitializeComponent();
        }




        private void Frmuser_Load(object sender, EventArgs e)
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

            clconnection conn = new clconnection();
            dataGriduser.DataSource = conn.Obterdados("select * from users;");

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
            if (Conn.Cadastrar(txtNome, textIdade, CBAno, CBMes, CBDia, textuser, textPassWord) > 0)
            {
                MessageBox.Show("Cadastro OK");
                teste = true;
            }
            else
            {
                MessageBox.Show("Não foi possivel");
                teste = false;
            }

            if (teste == true)
            {
                FrmLogIn log = new FrmLogIn();
                this.Hide();
                log.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmLogIn log = new FrmLogIn();
            this.Hide();
            log.ShowDialog();
        }

        private void dataGriduser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = Convert.ToInt32(dataGriduser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            resut.Text = cod.ToString();
            txtNome.Text = dataGriduser.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            textIdade.Text = dataGriduser.Rows[e.RowIndex].Cells["idade"].Value.ToString();
            textPassWord.Text = dataGriduser.Rows[e.RowIndex].Cells["pasword"].Value.ToString();
            textuser.Text = dataGriduser.Rows[e.RowIndex].Cells["NameUser"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cluser u = new cluser();
            int idade = Convert.ToInt32(textIdade.Text);
            if (u.altertable(textuser.Text, textPassWord.Text, txtNome.Text, idade, cod) > 0)
            {
                MessageBox.Show("Mudança efetuada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro na mudança de tabela");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cluser u = new cluser();
            if (u.excluir(cod) > 0)
            {
                MessageBox.Show("Usuario excluido!!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!!");
            }
        }
    }
}
