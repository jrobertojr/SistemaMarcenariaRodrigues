using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace SistemaMarcenariaRodrigues.Acoes.EntradaSaida
{
    class InventarioAcoesDB
    {
        private Conn Connection = new Conn();

        public List<string> Count(int id, int operacao, int produto, string fornecedor, int status)
        {
            try
            {
                List<string> retorno = new List<string>();
                bool resultadoStatus = status == 1 ? false : true;

                string query = $@"
                    SELECT 
	                    COUNT(*)
                    FROM inventario
                    WHERE id > 0 ";

                if (id > 0)
                    query += $" AND id = {id} ";
                if (operacao > 0)
                    query += $" AND operacao = {operacao} ";
                if (produto > 0)
                    query += $" AND produto = {produto} ";
                if (fornecedor != null)
                    query += $" AND fornecedor LIKE '%{produto}%' ";
                if (status > 0)
                    query += $" AND status = {resultadoStatus} ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Columns.Count; i++)
                    retorno.Add(tabela.Rows[0][i].ToString());

                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar quantidade de Inventario -- {ex}");
                return null;
            }
        }

        public List<InventarioModel> Select(int id, int operacao, int produto, string fornecedor, int status, string ordem, int? ultimaPosicao,
            int? numeroDeRegistos)
        {
            try
            {
                List<InventarioModel> retorno = new List<InventarioModel>();
                InventarioAcoes inventarioAcoes = new InventarioAcoes();
                bool resultadoStatus = status == 1 ? false : true;

                string query = $@"
                    SELECT 
	                    I.id AS id,
	                    I.produto AS produto,
                        P.produto AS nomeProduto,
	                    I.operacao AS operacao,
                        O.operacaofiscal AS operacaofiscal,
	                    I.quantidade AS quantidade,
	                    I.valorentrada AS valorentrada,
	                    I.serie AS serie,
	                    I.notaFiscal AS notaFiscal,
	                    I.fornecedor AS fornecedor,
	                    I.complemento AS complemento,
	                    I.status AS status,
	                    I.data AS data
                    FROM inventario AS I
                    INNER JOIN produtos AS P
	                    ON P.id = I.produto
                    INNER JOIN operacoes AS O
	                    ON O.id = I.operacao
                    WHERE I.id > 0 ";

                if (id > 0)
                    query += $" AND I.id = {id} ";
                if (operacao > 0)
                    query += $" AND I.operacao = {operacao} ";
                if (produto > 0)
                    query += $" AND I.produto = {produto} ";
                if (fornecedor != null)
                    query += $" AND I.fornecedor LIKE '%{produto}%' ";
                if (status > 0)
                    query += $" AND I.status = {resultadoStatus} ";
                if (ordem != "" && ordem != null)
                {
                    if (ordem == "crescente")
                        query += " ORDER BY I.id ASC ";
                    if (ordem == "decrescente")
                        query += " ORDER BY I.id DESC ";
                }
                if (ultimaPosicao != null && numeroDeRegistos != null)
                    query += $@" LIMIT {ultimaPosicao},{numeroDeRegistos} ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    InventarioModel inventarioModel = new InventarioModel()
                    {
                        Id = tabela.Rows[i]["id"].ToString() == "" ? 0 : (int)tabela.Rows[i]["id"],
                        Produto = tabela.Rows[i]["produto"].ToString() == "" ? 0 : (int)tabela.Rows[i]["produto"],
                        NomeProduto = tabela.Rows[i]["nomeProduto"].ToString(),
                        Operacao = tabela.Rows[i]["operacao"].ToString() == "" ? 0 : (int)tabela.Rows[i]["operacao"],
                        NomeOperacao = tabela.Rows[i]["operacaofiscal"].ToString(),
                        Quantidade = tabela.Rows[i]["quantidade"].ToString() == "" ? 0 : (int)tabela.Rows[i]["quantidade"],
                        ValorEntrada = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", double.Parse(tabela.Rows[i]["valorentrada"].ToString())),
                        ValorTotal = inventarioAcoes.ValorTotal(double.Parse(tabela.Rows[i]["valorentrada"].ToString()), (int)tabela.Rows[i]["quantidade"]),
                        Serie = tabela.Rows[i]["serie"].ToString(),
                        NotaFiscal = tabela.Rows[i]["notaFiscal"].ToString(),
                        Fornecedor = tabela.Rows[i]["fornecedor"].ToString(),
                        Complemento = tabela.Rows[i]["complemento"].ToString(),
                        Seq = inventarioAcoes.Seq((int)tabela.Rows[i]["produto"]),
                        Status = (bool)tabela.Rows[i]["status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["data"].ToString() == "" ? null : Convert.ToDateTime(tabela.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy")
                    };
                    retorno.Add(inventarioModel);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Inventario -- {ex}");
                return null;
            }
        }

        public string Insert(int produto, int operacao, int quantidade, double valorEntrada, string serie,
            string notaFiscal, string fornecedor, string complemento)
        {
            try
            {
                if (produto <= 0 || operacao <= 0 || quantidade <= 0 || valorEntrada == null ||
                    fornecedor == null);

                string query = $@"
                    INSERT
                    INTO INVENTARIO (
	                    produto,
                        operacao,
                        quantidade,
                        valorentrada,
                        serie,
                        notaFiscal,
                        fornecedor,
                        complemento,
	                    status,
	                    data)
                    VALUES (
	                    {produto},
                        {operacao},
                        {quantidade},
                        {valorEntrada},
                        '{serie}',
                        '{notaFiscal}',
                        '{fornecedor}',
                        '{complemento}',
                        true,
                        NOW())";

                Connection.Sql(query);

                return "Inventario cadastrado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao cadastrar Inventario -- {ex}");
                return "Erro ao cadastrar Inventario";
            }
        }

        public string Update(int id, int produto, int operacao, int quantidade, double valorEntrada, string serie,
            string notaFiscal, string fornecedor, string complemento, bool status)
        {
            try
            {
                string query = $@"
                    UPDATE
                    inventario SET
	                    produto = {produto},
                        operacao = {operacao},
                        quantidade = {quantidade},
                        valorentrada = {valorEntrada},
                        serie = '{serie}',
                        notaFiscal = '{notaFiscal}',
                        fornecedor = '{fornecedor}',
                        complemento = '{complemento}',
                        status = {status},
                        data = NOW()
                    WHERE id = {id}";

                Connection.Sql(query);

                return "Inventario atualizado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao atualizar Inventario -- {ex}");
                return "Erro ao atualizar Inventario";
            }
        }
    }
}
