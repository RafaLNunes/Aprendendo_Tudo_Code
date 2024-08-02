using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC.Modelo
{
    public class ModeloUser
    {
        

        //declaro as variaveis do sistema com relacao ao banco de dados
        public String ID_Aluno;
        public String Nome_Completo;
        public String UserName;
        public String Password;
        public String Ano_Escolar;
        public String Cargo;
        public String Unidade;

        public ModeloUser()
        {

            //iniciar as variaveis zeradas

            ID_Aluno = "";
            Nome_Completo = "";
            UserName = "";
            Password = "";
            Ano_Escolar = "";
            Cargo = "";
            Unidade = "";

    }
    }


}
