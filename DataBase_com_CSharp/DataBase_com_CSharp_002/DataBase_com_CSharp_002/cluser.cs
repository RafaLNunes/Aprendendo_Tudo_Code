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

    }
}
