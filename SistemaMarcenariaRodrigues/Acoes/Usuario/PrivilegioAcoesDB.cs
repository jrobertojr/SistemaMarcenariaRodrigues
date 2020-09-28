using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarcenariaRodrigues.Acoes.Usuario
{
    class PrivilegioAcoesDB
    {
        Conn Connection = new Conn();

        public List<string> Count(string nome, string descricao, int status, string dataInicio, string dataFim)
        {
            try
            {
                List<string> retorno = new List<string>();
                bool statusResultado = status == 1 ? true : false;

                string query = $@"
                    SELECT 
	                    COUNT(*)
                    FROM privilegio";

                if (nome != null)
                    query += $" AND nome LIKE '%{nome}%' ";
                if (descricao != null)
                    query += $" AND descricao LIKE '%{descricao}%' ";
                if (status > 0)
                    query += $" AND status = {statusResultado} ";
                if (dataInicio != null && dataFim != null)
                    query += $" AND DATE(data) BETWEEN '{dataInicio} 00:00:00' AND '{dataFim} 12:00:00' ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Columns.Count; i++)
                    retorno.Add(tabela.Rows[0][i].ToString());

                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Privilegio -- {ex}");
                return null;
            }
        }

        public List<PrivilegioModel> Select(string nome, string descricao, int status, string dataInicio, string dataFim,
            string ordem, int? ultimaPosicao, int? numeroDeRegistos)
        {
            try
            {
                List<PrivilegioModel> retorno = new List<PrivilegioModel>();
                bool statusResultado = status == 1 ? true : false;

                string query = $@"
                    SELECT 
	                    id,
                        nome,
                        descricao,
                        status,
                        data
                    FROM privilegio
                    WHERE id > 0";

                if (nome != null)
                    query += $" AND nome LIKE '%{nome}%' ";
                if (descricao != null)
                    query += $" AND descricao LIKE '%{descricao}%' ";
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

                if (tabela.Rows.Count <= 0)
                    return null;

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    PrivilegioModel privilegioModel = new PrivilegioModel()
                    {
                        Id = (int)tabela.Rows[i]["id"],
                        Nome = tabela.Rows[i]["nome"].ToString(),
                        Descricao = tabela.Rows[i]["descricao"].ToString(),
                        Status = (bool)tabela.Rows[i]["status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["data"].ToString() == "" ? null :
                            Convert.ToDateTime(tabela.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy")
                    };
                    retorno.Add(privilegioModel);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar dados de Privilegio -- {ex}");
                return null;
            }
        }
    }
}
