using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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



    }
}