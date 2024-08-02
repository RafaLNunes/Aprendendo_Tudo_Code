using Aprendendo_MVC.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC.Controle
{
    public class UserControle
    {
        //chamo o objeto da conexao
        ClConectection con = new ClConectection();


        //metodo para cadastrar 

        public bool Inserir_Cadastro(ModeloUser livro)
        {
            bool resultado = false;
            try
            {
                //inicializar a variavel resultado da opercao
                string sql = "insert into Table_User(ID_Aluno, Nome_Completo, NameUser, Senha)values(@ID_Aluno, @Nome_Completo, @UserName, @Password)";
                //monto o valor de atributos da tabela usuario
                string[] campos = {"@ID_Aluno", "@Nome_Completo", "@UserName", "@Password", "@IMG_User" };
                //monto o vetor com os valores do formulario
                string[] valores = { livro.ID_Aluno, livro.Nome_Completo.ToString(), livro.UserName.ToString(), livro.Password.ToString()};
            
                //testar o insert no banco de dados
                if (con.cadastrar(0, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            

            return resultado;


        }
    }
}
