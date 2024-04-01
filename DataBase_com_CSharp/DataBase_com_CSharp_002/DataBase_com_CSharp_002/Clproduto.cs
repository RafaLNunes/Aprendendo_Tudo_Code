using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_com_CSharp_002
{
    internal class Clproduto
    {
        public int Code;
        public String nome;
        public float preco;
        public int qtd_prod;
        public int fornecedor;
        public String foto;

        public Clproduto() 
        {
            Code =0;
            nome = "";
            preco = 0;
            qtd_prod = 0;
            fornecedor = 0;
            foto = "";
        }

        public int Cadastrar(Clproduto prod)
        {
            int reg = 0;

            string sql = $"insert into Produto(nome_prod, preco_prod, qtd_prod, CFK_fornc, foto_prod) values(@nome,@preco,@qtd,@fornc,@foto);";
            string[] campo = { "@nome", "@preco", "@qtd", "@fornc", "@foto" };

            Object[] values = { prod.nome, prod.preco, prod.qtd_prod, prod.fornecedor, prod.foto };
            clconnection conn = new clconnection();
            if(conn.cadastro(sql, campo, values) > 0)
            {
                MessageBox.Show("Cadastro Efetuado!!!");
            }
            return reg;
        }
    }
}
