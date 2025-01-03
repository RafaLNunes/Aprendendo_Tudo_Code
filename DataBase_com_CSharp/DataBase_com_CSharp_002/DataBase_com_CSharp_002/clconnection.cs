﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataBase_com_CSharp_002
{
    public class clconnection
    {

        static private String Server = "127.0.0.1";
        static private String DB = "Teste_DataBase";
        static private String user = "root";
        static private String password = "";
        public MySqlConnection Connections = null;
        static private String STRConect = $"server={Server};database={DB};user id={user};senha={password};";


        public MySqlConnection TestConnection()
        {
            Connections = new MySqlConnection(STRConect);

            return Connections;
        }

        public Int32 Cadastrar(TextBox textBox, TextBox textBox1, ComboBox comboBox, ComboBox comboBox1, ComboBox comboBox2, TextBox textBox2, TextBox textBox3, int Carg, String cam_ft)
        {
            Int32 reg = 0;
            try
            {
                Connections = TestConnection();

                Connections.Open();

                int h = DateTime.Now.Hour;
                int m = DateTime.Now.Minute;
                int s = DateTime.Now.Second;
                //nome
                String nome = textBox.Text;
                //idade
                Int32 idade = Convert.ToInt32(textBox1.Text);
                //ano
                String ano = $"{Convert.ToInt32(comboBox.Text)}-{Convert.ToInt32(comboBox1.Text)}-{Convert.ToInt32(comboBox2.Text)} {h}:{m}:{s}";
                //nameuser
                String username = textBox2.Text;
                //password
                String password = textBox3.Text;
                //foto
                String ft = cam_ft;

                String sql = $"Insert into users(Nome, idade, ano, Nameuser, pasword, Cam_FT,CFK_perfil) values('{nome}', {idade}, '{ano}', '{username}', '{password}', '{ft}', {Carg});";
                MySqlCommand cmd = new MySqlCommand(sql, Connections);

                reg = cmd.ExecuteNonQuery();
                Connections.Close();





                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro em: {ex.Message}");
            }






            return reg;
        }

        public DataTable Obterdados(String sql)
        {

            DataTable dt = new DataTable();
            Connections = TestConnection();
            Connections.Open();

            MySqlCommand cmd = new MySqlCommand(sql, Connections);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);


            return dt;
        }

        public int cadastro(string sql, string[] campos, object[] values)
        {
            int reg = 0;

            try
            {
                Connections = TestConnection();
                Connections.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Connections);
                for (int i = 0; i < values.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], values[i]);
                }

                reg = cmd.ExecuteNonQuery();
                Connections.Clone();
           }catch(Exception ex)
            {
               MessageBox.Show("Erro: " + ex.Message);
            }

            return reg;
        }


    }
}