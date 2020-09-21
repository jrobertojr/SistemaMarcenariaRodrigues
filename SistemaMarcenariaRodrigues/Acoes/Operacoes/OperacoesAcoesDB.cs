using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMarcenariaRodrigues.Acoes.Operacoes
{
    class OperacoesAcoesDB
    {
        private Conn Connection = new Conn();

        public List<OperacoesModel> Select(int status, bool filtro)
        {
            try
            {
                List<OperacoesModel> retorno = new List<OperacoesModel>();
                bool ResultadoStatus = false;
                if (status > 0)
                    ResultadoStatus = status == 1 ? true : false;


                string query = $@"
                    SELECT
                        id,
	                    operacaofiscal,
                        tipomovimento,
                        status,
                        data
                    FROM operacoes
                    WHERE id > 0";

                if (status > 0)
                    query += $" AND status = {ResultadoStatus} ";

                DataTable tabela = Connection.SqlDataTable(query);
                if (filtro)
                    retorno.Add(new OperacoesModel() { Id = 0, Operacao = "Todos", Movimento = "Todos" });

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    OperacoesModel operacoesAcoesDB = new OperacoesModel()
                    {
                        Id = tabela.Rows[i]["id"].ToString() == "" ? 0 : (int)tabela.Rows[i]["id"],
                        Operacao = tabela.Rows[i]["operacaofiscal"].ToString(),
                        Movimento = tabela.Rows[i]["tipomovimento"].ToString(),
                        Status = (bool)tabela.Rows[i]["status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["data"].ToString()
                    };
                    retorno.Add(operacoesAcoesDB);
                }

                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar Operações -- {ex}");
                return null;
            }
        }
    }
}
