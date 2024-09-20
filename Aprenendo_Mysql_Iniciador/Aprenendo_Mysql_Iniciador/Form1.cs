using System.Diagnostics;
using System.Reflection.Metadata;

namespace Aprenendo_Mysql_Iniciador
{
    public partial class Form1 : Form
    {
        Clconection conexao = new Clconection();
        ClControleConexao conetrole_Conexao = new ClControleConexao();
        

        string cam_File = /*Path.Combine(Directory.GetCurrentDirectory(), */"DT_Nomes.sql"/*)*/;

        public Form1()
        {

            //Process.Start("C:\\xampp\\mysql\\bin\\mysqld.exe");

            MessageBox.Show("");

            MessageBox.Show(Path.GetFullPath("xampp"));
            conetrole_Conexao.ExecutarScriptSQL(cam_File, "DT_Name");
            InitializeComponent();
        }


    }
}
