using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_com_CSharp_002
{
    internal class Clproduto
    {
        int Code;
        String nome;
        double preco;
        int qtd_prod;
        int fornecedor;
        String foto;

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

            string sql = $"insert into Produto(nome_prod, preco_prod, qtd_prod, CFK_fornc, foto_prod) values('@nome',@preco,@qtd,@fornc,'@foto');";
            string[] campo = { "@nome", "@preco", "@qtd", "@fornc", "@foto" };

            Object[] values = { prod.Code, prod.nome, prod.preco, prod.qtd_prod, prod.fornecedor, prod.foto };

            return reg;
        }
    }
}
