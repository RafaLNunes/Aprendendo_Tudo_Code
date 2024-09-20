using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aprenendo_Mysql_Iniciador
{
    public class Clconection
    {

        //private string connectionString = "server=localhost;database=DT_Name;uid=root;pwd=senha"; // Atualize conforme necessário

        static private String server = "localhost"; //localhost
        //static private String DataBase = "DT_name"; // Nome do Data Base // ainda não vou usar
        static private String User = "root"; //root senha vazia
        static private String PassWord = ""; //senha do root é sempre vazia
        public MySqlConnection Conect = null; // garantia de que eesta aberta e vazia
        static private String strConect = $"server={server};user id={User};password={PassWord};";/*$"server={server};database={DataBase};user id={User};password={PassWord};"*/


 
        public bool startProcessXampp()
        {
            //Process.Start();

            return true;
        }

        public MySqlConnection GetConectection()
        {
            Conect = new MySqlConnection(strConect);

            return Conect;
        }

        public DataTable obterdados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            Conect = GetConectection();//obtenho a conexao
            Conect.Open();//abro o banco
            MySqlCommand cmd = new MySqlCommand(sql, Conect);
            //monto a estrutura das informações obtidas
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //adiciona a datatable os valores 
            adapter.Fill(dt);

            return dt;
        }

    }
}






