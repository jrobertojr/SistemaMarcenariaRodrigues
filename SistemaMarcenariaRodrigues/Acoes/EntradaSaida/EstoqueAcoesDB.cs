using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace SistemaMarcenariaRodrigues.Acoes.EntradaSaida
{
    class EstoqueAcoesDB
    {
        private Conn Connection = new Conn();

        public List<string> Count(int id)
        {
            try
            {
                List<string> retorno = new List<string>();

                string query = $@"
                    SELECT 
	                    COUNT(I.id)
                    FROM inventario AS I
                    INNER JOIN produtos AS P
	                    ON P.id = I.produto
                    INNER JOIN operacoes AS O
                     ON O.id = I.operacao
                    WHERE P.id > 0";
                if (id > 0)
                    query += $" AND P.id = {id} ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Columns.Count; i++)
                    retorno.Add(tabela.Rows[0][i].ToString());

                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Estoque -- {ex}");
                return null;
            }
        }

        public List<EstoqueModel> Select(int id, int? ultimaPosicao, int? numeroDeRegistos)
        {
            try
            {
                List<EstoqueModel> retorno = new List<EstoqueModel>();
                int quantidadeTotal = 0;
                double valor = 0;
                double valorEntada = 0;

                string query = $@"
                    SELECT 
	                    P.id AS Codigo,
                        O.id AS IdOperacao,
                        O.tipomovimento AS TipoMovimento,
                        I.data AS Data,
                        I.quantidade AS Qtd,
                        I.valorentrada AS ValorEntrada,
                        O.operacaofiscal AS OperacaoFiscal,
                        I.serie AS Serie,
                        I.notaFiscal AS NotaFiscal,
                        I.fornecedor AS FornecedorCliente,
                        I.complemento AS Complemento
                    FROM inventario AS I
                    INNER JOIN produtos AS P
	                    ON P.id = I.produto
                    INNER JOIN operacoes AS O
                     ON O.id = I.operacao
                    WHERE P.id > 0";
                if (id > 0)
                    query += $" AND P.id = {id} ";
                query += " ORDER BY I.data ";
                if (ultimaPosicao != null && numeroDeRegistos != null)
                    query += $@" LIMIT {ultimaPosicao},{numeroDeRegistos} ";

                DataTable tabela = Connection.SqlDataTable(query);
                
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    int qtdTotal = QuantidadeTotal((int)tabela.Rows[i]["IdOperacao"], quantidadeTotal, (int)tabela.Rows[i]["Qtd"]);

                    double vTotal = 0;
                    if (i == 0)
                        vTotal = ValorTotal((int)tabela.Rows[i]["IdOperacao"], valor, double.Parse(tabela.Rows[i]["ValorEntrada"].ToString()), (int)tabela.Rows[i]["Qtd"]);
                    else
                        vTotal = ValorTotal((int)tabela.Rows[i]["IdOperacao"], valor, valorEntada, (int)tabela.Rows[i]["Qtd"]);


                    double cMedio = vTotal / qtdTotal;
                    double vMovimento = ValorMovimento((int)tabela.Rows[i]["IdOperacao"], (int)tabela.Rows[i]["Qtd"], double.Parse(tabela.Rows[i]["ValorEntrada"].ToString()), cMedio);

                    EstoqueModel estoqueModel = new EstoqueModel()
                    {
                        Codigo = tabela.Rows[i]["Codigo"].ToString() == "" ? 0 : (int)tabela.Rows[i]["Codigo"],
                        IdOperacao = tabela.Rows[i]["IdOperacao"].ToString() == "" ? 0 : (int)tabela.Rows[i]["IdOperacao"],
                        TipoMovimento = tabela.Rows[i]["TipoMovimento"].ToString(),
                        Data = tabela.Rows[i]["Data"].ToString() == "" ? null : Convert.ToDateTime(tabela.Rows[i]["Data"].ToString()).ToString("dd/MM/yyyy"),
                        Quantidade = tabela.Rows[i]["Qtd"].ToString() == "" ? 0 : (int)tabela.Rows[i]["Qtd"],
                        Valor = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", double.Parse(tabela.Rows[i]["ValorEntrada"].ToString())),
                        OperacaoFiscal = tabela.Rows[i]["OperacaoFiscal"].ToString(),
                        Serie = tabela.Rows[i]["Serie"].ToString(),
                        Notafiscal = tabela.Rows[i]["NotaFiscal"].ToString(),
                        FornecedorCliente = tabela.Rows[i]["FornecedorCliente"].ToString(),
                        Complemento = tabela.Rows[i]["Complemento"].ToString(),
                        QuantidadeTotal = qtdTotal,
                        ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", vTotal),
                        CustoMedio = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", cMedio),
                        ValorMovimento = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", vMovimento)
                    };
                    retorno.Add(estoqueModel);

                    if ((int)tabela.Rows[i]["IdOperacao"] == 1)
                        valorEntada = double.Parse(tabela.Rows[i]["ValorEntrada"].ToString());
                    quantidadeTotal += qtdTotal;
                    valor += vTotal;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Estoque -- {ex}");
                return null;
            }
        }

        private int QuantidadeTotal(int operacao, int quantidade, int novaQuantidade)
        {
            if (operacao == 1)
                quantidade += novaQuantidade;
            else if (operacao == 2)
                quantidade -= novaQuantidade;
            else
                quantidade += 0;

            return quantidade;
        }

        private double ValorTotal(int operacao, double valor, double novoValor, int quantidade)
        {
            if (operacao == 1)
                if (valor > 0)
                    valor += novoValor;
                else
                    valor = quantidade * novoValor;
            else if (operacao == 2)
                valor -= quantidade * novoValor;
            else
                valor += 0;

            return valor;
        }

        private double ValorMovimento(int operacao, int quantidade, double valor, double custoMedio)
        {
            double retorno = 0;

            if (operacao == 1)
                retorno = quantidade * valor;
            else if (operacao == 2)
                retorno = quantidade * custoMedio;
            else
                retorno = 0;

            return retorno;
        }
    }
}
