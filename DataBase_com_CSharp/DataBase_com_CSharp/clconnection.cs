using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBase_com_CSharp
{
    public class clconnection
    {

        static private String server = "127.0.0.1"; //localhost
        static private String DataBase = "Teste_DataBase"; // Nome do Data Base
        static private String User = "root"; //root senha vazia
        static private String PassWord = ""; //senha do root é sempre vazia
        public MySqlConnection Conect = null; // garantia de que eesta aberta e vazia
        static private String strConect = $"Server={server};database={DataBase};user id={User};password=`{PassWord};";

        public MySqlConnection GetConnection()
        {
            Conect = new MySqlConnection(strConect);

            return Conect;
        }


        public int cadastrar(TextBox textBox, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            int registro = 0;

            


            try
            {

                //nome
                String name = textBox.Text;
                //idade
                Int32 idade = Convert.ToInt32(textBox1.Text);
                //ano
                String ano = textBox2.Text;
                //user
                String UserName = textBox3.Text;
                //password
                String PassWord = textBox4.Text;

                //Tables
                String[] table = new String[4] { "Users", "Produto", "juncao", "" };

                Conect = GetConnection();
                Conect.Open();

                String sql = $"insert into {table[0]} (Nome, idade, ano, NameUser, pasword) values ('{name}', '{idade}', '{ano}', '{UserName}', '{PassWord}')";

                MySqlCommand cmd = new MySqlCommand(sql, Conect);
            }catch(Exception ex)
            {
                registro = 1;
                MessageBox.Show($"Erro: {ex}");

            }



            return registro;
        }

    }
}
