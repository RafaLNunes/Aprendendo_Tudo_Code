using Aprendendo_MVC.Controle;
using Aprendendo_MVC.Modelo;
using Google.Protobuf.WellKnownTypes;

namespace Aprendendo_MVC
{
    public partial class Form1 : Form
    {
        UserControle Controle_User = new UserControle();
        ModeloUser Modelo_User = new ModeloUser();
        ClConectection clconexao = new ClConectection();

        public Form1()
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
                if(!string.IsNullOrEmpty(txtID.Text))
                {
                    Modelo_User.Table_Mean =  "Table_User";
                    Modelo_User.ID_Aluno = txtID.Text;
                    Modelo_User.Nome_Completo = txtNome.Text;
                    Modelo_User.UserName = txtUserName.Text;
                    Modelo_User.Password = txtPassWord.Text;
                    if (Controle_User.Inserir_Cadastro(Modelo_User) == true)
                    {
                        MessageBox.Show("Feito");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro no Cadastro:c"+ ex.Message);
            }
        }
    }
}
