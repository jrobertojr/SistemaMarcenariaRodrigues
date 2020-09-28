using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Produtos;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMarcenariaRodrigues.Acoes.Produtos
{
    class ProdutosAcoesDB
    {
        private Conn Connection = new Conn();

        public List<string> Count(int id, string produto, string fornecedor, string dataInicio, string dataFim, int status)
        {
            try
            {
                List<string> listaResultado = new List<string>();
                bool statusResultado = status == 1 ? true : false;

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
                if (status > 0)
                    query += $" AND status = {statusResultado} ";
                if (dataInicio != null && dataFim != null)
                    query += $" AND DATE(data) BETWEEN '{dataInicio} 00:00:00' AND '{dataFim} 12:00:00' ";

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

        public List<ProdutosModel> Select(int id, string produto, string fornecedor, string dataInicio, string dataFim,
            int status, string ordem, int? ultimaPosicao, int? numeroDeRegistos)
        {
            try
            {
                List<ProdutosModel> retorno = new List<ProdutosModel>();
                bool statusResultado = status == 1 ? true : false;

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
                if (status > 0)
                    query += $" AND status = {statusResultado} ";
                if (dataInicio != null && dataFim != null)
                    query += $" AND DATE(data) BETWEEN '{dataInicio} 00:00:00' AND '{dataFim} 12:00:00' ";
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
                        Data = Convert.ToDateTime(tabela.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy")
                    };
                    retorno.Add(produtosModel);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Produto -- {ex}");
                return null;
            }
        }

        public string Insert(string produto, string dimensoes, string fornecedor, string detalhe)
        {
            try
            {
                if (produto == "" || dimensoes == "" || fornecedor == "")
                    return "Produto, Dimensões e Fornecedor são obrigatórios";

                string query = $@"
                    INSERT 
                    INTO produtos (
                        produto,
                        dimensoes,
                        fornecedor,
                        detalhe,
                        status,
                        data)
                    VALUES (
                        '{produto}',
                        '{dimensoes}',
                        '{fornecedor}',
                        '{detalhe}',
                        1,
                        NOW())";

                Connection.Sql(query);

                return "Produto cadastrado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao enviar cadastro de produtos -- {ex}");
                return "Erro ao cadastrar produto";
            }
        }

        public string Update(int id, string produto, string dimensoes, string fornecedor, string detalhe, bool status)
        {
            try
            {
                if (id <= 0 || produto == "" || dimensoes == "" || fornecedor == "")
                    return "Produto, Dimensões e Fornecedor são obrigatórios";

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
