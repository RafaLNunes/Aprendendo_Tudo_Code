using Aprendendo_MVC;
using System.Data;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;

namespace Apredendo_Catalogo
{
    public partial class FrmCatalogo : Form
    {

        ClConectection conexao = new ClConectection();
        DataTable dt = new DataTable();
        
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = conexao.obterdados("Select * from Table_Livro;");

            int registro = 0;
            int x=0, y=0;

            for (registro= 0; registro < dt.Rows.Count; registro++)
            {
                // panel
                Panel livros = new Panel();
                
                livros.BorderStyle=BorderStyle.FixedSingle;
                livros.Location = new Point(x,y);
                livros.Height = 300;
                livros.Width = 200;



                Label CD_Livro = new Label();

                CD_Livro.Name = "Order_Livro";
                CD_Livro.Text = dt.Rows[registro]["CD_Livro"].ToString();
                CD_Livro.Location = new Point(20,y);

                Label Nome_Libro = new Label();
                Nome_Libro.Name = "Nome_Livro";
                Nome_Libro.Text = dt.Rows[registro]["Nome_Livro"].ToString();
                Nome_Libro.Location = new Point(20,35);

                Label Autor = new Label();
                Autor.Name = "Autor_Livro";
                Autor.Text = dt.Rows[registro]["Autor_Livro"].ToString();
                Autor.Location = new Point(20, 70);

                Button bntSeguir = new Button();
                bntSeguir.Name = "Seguir";
                bntSeguir.Text = "Dar uma Olhada";
                bntSeguir.Location = new Point(20, 105);

                livros.Controls.Add( CD_Livro );
                livros.Controls.Add(Nome_Libro);
                livros.Controls.Add(Autor);
                livros.Controls.Add(bntSeguir);

                flowLayoutPanel1.Controls.Add(livros);

            }
        }
    }
}
