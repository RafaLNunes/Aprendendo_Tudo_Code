using _002.Projeto_Exercicio;
using System.Numerics;

namespace aprendendo_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            veiculo v1 = new veiculo();
            v1.chassi = "14567876543";
            MessageBox.Show("Placa: " + v1.setPlaca() + "\nChassi: " + v1.chassi);



        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            veiculo v2 = new veiculo();
            v2.chassi = textchassi.Text;
            MessageBox.Show("Seu chassi: " + v2.chassi);
            v2.setplaca(textplaca.Text);
            MessageBox.Show("Sua placa: " + v2.getPlaca());
        }
    }
}
