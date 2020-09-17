using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Produtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarcenariaRodrigues.Acoes.Produtos
{
    class ProdutosAcoesDB
    {
        private Conn Connection = new Conn();

        public List<string> Count(int id, string produto, string fornecedor)
        {
            try
            {
                List<string> listaResultado = new List<string>();

                string query = $@"
                SELECT 
	                COUNT(*)
                FROM produtos
                WHERE id > 0";

                if (id > 0)
                    query += $" AND id = {id} ";
                if (produto != null)
                    query += $" AND produto LIKE '%{produto}%' ";
                if (fornecedor != null)
                    query += $" AND fornecedor LIKE '%{fornecedor}%' ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Columns.Count; i++)
                    listaResultado.Add(tabela.Rows[0][i].ToString());

                return listaResultado;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar contagem de produtos -- {ex}");
                return null;
            }
        }

        public List<ProdutosModel> Select(int id, string produto, string fornecedor, string ordem, int? ultimaPosicao,
            int? numeroDeRegistos)
        {
            try
            {
                List<ProdutosModel> retorno = new List<ProdutosModel>();

                string query = $@"
                SELECT 
	                id,
                    produto,
                    dimensoes,
                    fornecedor,
                    detalhe,
                    status,
                    data
                FROM produtos
                WHERE id > 0";

                if (id > 0)
                    query += $" AND id = {id} ";
                if (produto != null)
                    query += $" AND produto LIKE '%{produto}%' ";
                if (fornecedor != null)
                    query += $" AND fornecedor LIKE '%{fornecedor}%' ";
                if (ordem != "" && ordem != null)
                {
                    if (ordem == "crescente")
                        query += " ORDER BY id ASC ";
                    if (ordem == "decrescente")
                        query += " ORDER BY id DESC ";
                }
                if (ultimaPosicao != null && numeroDeRegistos != null)
                    query += $@" LIMIT {ultimaPosicao},{numeroDeRegistos} ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    ProdutosModel produtosModel = new ProdutosModel()
                    {
                        Id = tabela.Rows[i]["id"].ToString() == "" ? 0 : (int)tabela.Rows[i]["id"],
                        Produto = tabela.Rows[i]["produto"].ToString(),
                        Dimensoes = tabela.Rows[i]["dimensoes"].ToString(),
                        Fornecedor = tabela.Rows[i]["fornecedor"].ToString(),
                        Detalhe = tabela.Rows[i]["detalhe"].ToString(),
                        Status = (bool)tabela.Rows[i]["status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["data"].ToString()
                    };
                    retorno.Add(produtosModel);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de produto -- {ex}");
                return null;
            }
        }

        public string Insert(string produto, string dimensoes, string fornecedor, string detalhe)
        {
            try
            {
                if (produto == "" || dimensoes == "" || fornecedor == "" || detalhe == "")
                    return "Todos os campos devem ser prenchido";

                string query = $@"
                INSERT 
                INTO produtos (produto, dimensoes, fornecedor, detalhe, status, data)
                VALUES ('{produto}', '{dimensoes}', '{fornecedor}', '{detalhe}', 1, NOW())";

                Connection.Sql(query);

                return "Produto cadastrado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao enviar cadastro de produtos -- {ex}");
                return null;
            }
        }

        public string Update(int id, string produto, string dimensoes, string fornecedor, string detalhe, bool status)
        {
            try
            {
                if (id <= 0 || produto == "" || dimensoes == "" || fornecedor == "" || detalhe == "")
                    return "Todos os campos devem ser prenchido";

                string query = $@"
                    UPDATE 
                    produtos SET 
	                    produto = '{produto}', 
                        dimensoes = '{dimensoes}', 
                        fornecedor = '{fornecedor}', 
                        detalhe = '{detalhe}', 
                        status = {status}, 
                        data = NOW()
                    WHERE id = {id}";

                Connection.Sql(query);

                return "Produto atualizado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao enviar atualização de produtos -- {ex}");
                return null;
            }
        }
    }
}
