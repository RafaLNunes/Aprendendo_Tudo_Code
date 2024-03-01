namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(textBox1.Text);
                int resut = valor / 0;

                MessageBox.Show($"Seu resultado: {resut}", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            finally
            {
                MessageBox.Show("Tchau");
                Close();
            }
        }
    }
}
