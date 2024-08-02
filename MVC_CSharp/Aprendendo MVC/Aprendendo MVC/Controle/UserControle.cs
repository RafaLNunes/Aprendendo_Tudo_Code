using Aprendendo_MVC.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_MVC.Controle
{
    internal class UserControle
    {
        //chamo o objeto da conexao
        ClConectection con = new ClConectection();


        //metodo para cadastrar 

        public bool cadastrar(ModeloUser livro)
        {
            bool resultado = false;
            try
            {
                //inicializar a variavel resultado da opercao
                string sql = "insert into livro(Nome_Livro, QTD_Estoque, Numb_Paginas, Edicao_Livro, IMG_Livro, Descricao_Livro)values(@Nome_Livro, @QTD_Estoque, @Numb_Paginas, @Edicao_Livro, @IMG_Livro, @Descricao_Livro)";
                //monto o valor de atributos da tabela usuario
                string[] campos = { "@Nome_Livro", "@QTD_Estoque", "@Numb_Paginas", "@Edicao_Livro", "@IMG_Livro", "@Descricao_Livro" };
                //monto o vetor com os valores do formulario
                string[] valores = { livro.ID_Aluno, livro.Nome_Completo.ToString(), livro.UserName.ToString(), livro.Password.ToString(), livro.Ano_Escolar.ToString(), livro.Cargo.ToString(), livro.Unidade.ToString() };
            
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
