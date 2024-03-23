using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_CSharp_Origin
{
    internal class ClConnection
    {
        private static String DB = "Origin_User";
        private static String server = "127.0.0.1";
        private static String user = "root";
        private static String password = "";
        public MySqlConnection Connection= null;
        static private String STRConect = $"server={server};database={DB};user id={user};senha={password};";

        public MySqlConnection GetConnection()
        {
            Connection = new MySqlConnection(STRConect);
            return Connection;
        }

        public int SignUp(TextBox textBox, TextBox textBox1, TextBox textBox2, ComboBox comboBox, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            int reg = 0;
            try
            {
                //ano atual
                int ano_atual = DateTime.Now.Year;
                //nome completo
                String nome = textBox.Text;
                //Idade
                int idade = ano_atual - Convert.ToInt32(comboBox3.Text);
                //user name
                String username = textBox1.Text;
                //password
                String password = textBox2.Text;
                //cargo
                int cargo = comboBox.SelectedIndex + 1;
                //Date
                String Date = $"{Convert.ToString(comboBox3.Text)}-{Convert.ToString(comboBox2.Text)}-{Convert.ToString(comboBox1.Text)}"; // YYYY-MM-DD
                //time
                String time = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute) + ":" + Convert.ToString(DateTime.Now.Second);// HH:MM:SS

                String sql = $"insert into users (Nome, Idade, Data_nasc, hora_registro, UserName, Passwords, CFK_perfil) values ('{nome}', {idade},'{Date}','{time}','{username}','{password}', {cargo});";

                MySqlCommand cmd = new MySqlCommand(sql, Connection);

                

                reg = Convert.ToInt32(cmd.ExecuteNonQuery());
                Connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            return reg;
        }


        public DataTable LogIn(TextBox textBox, TextBox textBox1)
        {
            DataTable reg = new DataTable();

            try
            {
                //User Name
                String nameuser = textBox.Text.Trim();
                //password
                String password = textBox1.Text.Trim();

                String sql = "select * from users where UserName=@nameuser and Passwords=@password";

                MySqlConnection com = GetConnection();

                MySqlCommand cmd = new MySqlCommand( sql, Connection);

                cmd.Parameters.AddWithValue("@nameuser", nameuser);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


            return reg;
        }





        public DataTable Obter_dados(string sql)
        {
            DataTable dt = new DataTable();

            Connection = GetConnection();
            Connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);



            return dt;
        }
    }
}
