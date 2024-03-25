using System.Data;
using System.Linq.Expressions;

namespace DataBase_com_CSharp_002
{
    public partial class Frmuser : Form
    {
        clconnection cot = new clconnection();
        clconnection Conn = new clconnection();
        int cod;
        bool teste;
        int Cargo;
        String Cam_FT;

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


            dataGriduser.DataSource = cot.Obterdados("select Users.Cod_User as 'Código', Users.Nome as 'Nome', Users.idade as 'Idade', Users.ano as 'Ano de cadastro', Users.NameUser as 'Name User',  Users.pasword as 'PassWord', perfil.cargo as 'Perfil do Usuário', Users.Cam_FT as 'Foto do User' from users inner join perfil on users.CFK_perfil = perfil.Cod_perfil;");


            CBperfil.DataSource = cot.Obterdados("select * from perfil;");
            CBperfil.DisplayMember = "cargo";
            CBperfil.ValueMember = "Cod_perfil";
            CBperfil.Text = String.Empty;

        }

        private void Teste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conn.TestConnection == null)
                {
                    MessageBox.Show("Conexão não foi feita");

                    dataGriduser.DataSource = cot.Obterdados("select * from users;");
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
            if (Conn.Cadastrar(txtNome, textIdade, CBAno, CBMes, CBDia, textuser, textPassWord, Cargo, Cam_FT) > 0)
            {
                MessageBox.Show("Cadastro OK");
                teste = true;

                dataGriduser.DataSource = cot.Obterdados("select * from users;");
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
            //LAno.Text = dataGriduser.Rows[e.RowIndex].Cells["Ano de cadastro"].Value.ToString();
            txtNome.Text = dataGriduser.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            textIdade.Text = dataGriduser.Rows[e.RowIndex].Cells["idade"].Value.ToString();
            textPassWord.Text = dataGriduser.Rows[e.RowIndex].Cells["PassWord"].Value.ToString();
            textuser.Text = dataGriduser.Rows[e.RowIndex].Cells["Name User"].Value.ToString();
            CBperfil.Text = dataGriduser.Rows[e.RowIndex].Cells["Perfil do Usuário"].Value.ToString();
            String cm_foto = @$"{dataGriduser.Rows[e.RowIndex].Cells["Foto do User"].Value.ToString()}";
            pictureBox1.Image = Image.FromFile(cm_foto);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cluser u = new cluser();
            int idade = Convert.ToInt32(textIdade.Text);
            if (u.altertable(textuser.Text, textPassWord.Text, txtNome.Text, idade, cod, CBperfil.SelectedIndex) > 0)
            {
                MessageBox.Show("Mudança efetuada com sucesso");

                dataGriduser.DataSource = cot.Obterdados("select * from users;");
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

                dataGriduser.DataSource = cot.Obterdados("select * from users;");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGriduser.DataSource = cot.Obterdados("select * from users;");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargo = Convert.ToInt32(((DataRowView)CBperfil.SelectedItem)["Cod_perfil"]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try{
                
                OpenFileDialog ft = new OpenFileDialog();
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if(ft.ShowDialog() == DialogResult.OK)
                {
                    //String fliepath = @$"{}";
                    pictureBox1.Image = new Bitmap(ft.FileName);
                    Cam_FT = @$"{ft.FileName}";
                }else
                {
                    MessageBox.Show("Não foi escolhido nenhuma imagem!!!");
                }

            }catch(Exception xe)
            {
                MessageBox.Show("Erro: " +  xe.Message);
            }
        }
    }
}
