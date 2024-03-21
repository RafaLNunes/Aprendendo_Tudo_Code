using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_com_CSharp_002
{
    internal class cluser
    {

        
        clconnection conn = new clconnection();



        public DataTable log(TextBox textBox, TextBox textBox1)
        {
            DataTable reg = new DataTable();
            


            try
            {
                String user = textBox.Text;
                String password = textBox1.Text;
                String sql = "select * from users where Nameuser=@user and pasword=@password";


                MySqlConnection com = conn.TestConnection();
                com.Open();                

                

                MySqlCommand cmd = new MySqlCommand(sql, com);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@user", user);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);

                //reg = cmd.ExecuteScalar();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro em: {ex.Message}");
            }

            return reg;
        }
        public int coseguir_tamanho()
        {
            int reg = 0;



            try
            {


                MySqlConnection com = conn.TestConnection();
                com.Open();

                MySqlCommand tama = new MySqlCommand("SELECT COUNT(*) FROM users;", com);


                reg = Convert.ToInt32(tama.ExecuteScalar());
                MessageBox.Show(reg.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

            return reg;
        }

        public int  altertable(String nameuser, String password, String nome,int idade, int ID)
        {
            int reg = 0;
            String sql = "update Users set Nome=@nome, NameUser=@nameuser, pasword=@password, idade=@idade where Cod_User=@cod";

            MySqlConnection com = conn.TestConnection();
            com.Open();

            MySqlCommand cmd = new MySqlCommand( sql, com);

            cmd.Parameters.AddWithValue("@nameuser", nameuser);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue ("@cod", ID);

            reg = Convert.ToInt32(cmd.ExecuteNonQuery());

            com.Close();
            return reg;
        }
        
        public int excluir(int ID)
        {
            int reg = 0;
            MySqlConnection com = conn.TestConnection();
            com.Open();
            String sql = "delete from Users where Cod_User=@cod;";
            MySqlCommand cmd = new MySqlCommand( sql, com);
            cmd.Parameters.AddWithValue("@cod", ID);
            reg = Convert.ToInt32(cmd.ExecuteNonQuery());
            com.Close();


            return reg;
        }
    }
}
