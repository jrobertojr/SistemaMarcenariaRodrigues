using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Criptografia;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMarcenariaRodrigues.Acoes.Usuario
{
    class UsuarioAcoesDB
    {
        private Conn Connection = new Conn();

        public List<string> Count(string usuario, string nome, string email, int privilegio, int status,
             string dataInicio, string dataFim)
        {
            try
            {
                List<string> listaResultado = new List<string>();
                bool statusResultado = status == 1 ? true : false;

                string query = $@"
                    SELECT 
	                    COUNT(*)
                    FROM usuario AS U
                    INNER JOIN privilegio AS P
	                    ON P.id = U.privilegio
                    WHERE U.id > 0";

                if (usuario != null)
                    query += $" AND U.usuario LIKE '%{usuario}%' ";
                if (nome != null)
                    query += $" AND U.nome LIKE '%{nome}%' ";
                if (nome != null)
                    query += $" AND U.email LIKE '%{email}%' ";
                if (privilegio > 0)
                    query += $" AND U.privilegio = {privilegio} ";
                if (status > 0)
                    query += $" AND U.status = {statusResultado} ";
                if (dataInicio != null && dataFim != null)
                    query += $" AND DATE(U.data) BETWEEN '{dataInicio} 00:00:00' AND '{dataFim} 12:59:59' ";

                DataTable tabela = Connection.SqlDataTable(query);

                for (int i = 0; i < tabela.Columns.Count; i++)
                    listaResultado.Add(tabela.Rows[0][i].ToString());

                return listaResultado;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar contagem de Usuarios -- {ex}");
                return null;
            }
        }

        public List<UsuarioModel> Select(string usuario, string nome, string email, int privilegio, int status,
             string dataInicio, string dataFim, string ordem, int? ultimaPosicao, int? numeroDeRegistos)
        {
            try
            {
                List<UsuarioModel> retorno = new List<UsuarioModel>();
                bool statusResultado = status == 1 ? true : false;

                string query = $@"
                    SELECT 
	                    U.id AS Id,
	                    U.usuario AS Usuario,
	                    U.senha AS Senha,
	                    U.nome AS Nome,
	                    U.email AS Email,
	                    U.privilegio AS Privilegio,
                        P.nome AS NomePrivilegio,
	                    U.status AS Status,
	                    U.data AS Data
                    FROM usuario AS U
                    INNER JOIN privilegio AS P
	                    ON P.id = U.privilegio
                    WHERE U.id > 0";

                if (usuario != null)
                    query += $" AND U.usuario LIKE '%{usuario}%' ";
                if (nome != null)
                    query += $" AND U.nome LIKE '%{nome}%' ";
                if (nome != null)
                    query += $" AND U.email LIKE '%{email}%' ";
                if (privilegio > 0)
                    query += $" AND U.privilegio = {privilegio} ";
                if (status > 0)
                    query += $" AND U.status = {statusResultado} ";
                if (dataInicio != null && dataFim != null)
                    query += $" AND DATE(U.data) BETWEEN '{dataInicio} 00:00:00' AND '{dataFim} 12:00:00' ";
                if (ordem != "" && ordem != null)
                {
                    if (ordem == "crescente")
                        query += " ORDER BY U.id ASC ";
                    if (ordem == "decrescente")
                        query += " ORDER BY U.id DESC ";
                }
                if (ultimaPosicao != null && numeroDeRegistos != null)
                    query += $@" LIMIT {ultimaPosicao},{numeroDeRegistos} ";

                DataTable tabela = Connection.SqlDataTable(query);

                if (tabela.Rows.Count <= 0)
                    return null;

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    UsuarioModel usuarioModel = new UsuarioModel()
                    {
                        Id = (int)tabela.Rows[i]["Id"],
                        Usuario = tabela.Rows[i]["Usuario"].ToString(),
                        Senha = tabela.Rows[i]["Senha"].ToString(),
                        Nome = tabela.Rows[i]["Nome"].ToString(),
                        Email = tabela.Rows[i]["Email"].ToString(),
                        IdPrivilegio = (int)tabela.Rows[i]["Privilegio"],
                        Privilegio = tabela.Rows[i]["NomePrivilegio"].ToString(),
                        Status = (bool)tabela.Rows[i]["Status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["Data"].ToString() == "" ? null : Convert.ToDateTime(tabela.Rows[i]["data"].ToString()).ToString("dd/MM/yyyy"),
                    };
                    retorno.Add(usuarioModel);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar valores de Usuario -- {ex}");
                return null;
            }
        }

        public string Insert(string usuario, string nome, string senha, string email, int privilegio)
        {
            if (usuario == null || senha == null || nome == null || email == null || privilegio == 0)
                return "Todos os campos são obrigatórios";

            string senhaMd5 = HashMd5.GerarMd5(senha);

            try
            {
                string query = $@"
                    INSERT
                    INTO usuario (
	                    usuario,
                        senha,
                        nome,
                        email,
                        privilegio,
                        status,
                        data)
                    VALUES (
                        '{usuario}',
                        '{senhaMd5}',
                        '{nome}',
                        '{email}',
                        {privilegio},
                        true,
                        NOW())";

                Connection.Sql(query);

                return "Usuário cadastrado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao cadastrar Usuario -- {ex}");
                return "Erro ao cadastrar Usuario, contate o desenvolvedor";
            }
        }

        public string Upgrade(int id, string usuario, string nome, string senha, string email, int privilegio, int status)
        {
            try
            {
                string senhaMd5 = null;
                bool statusResultado = status == 1 ? true : false;
                if (senha != null)
                    senhaMd5 = HashMd5.GerarMd5(senha);

                string query = $@"
                    UPDATE
                    usuario SET
	                    usuario = '{usuario}',";

                if (senhaMd5 != null)
                    query += $"senha = '{senhaMd5}',";

                query += $@"
                        
                        nome = '{nome}',
                        email = '{email}',
                        privilegio = {privilegio},
                        status = {statusResultado},
                        data = NOW()
                    WHERE id = {id} ";

                Connection.Sql(query);

                return "Inventario atualizado";
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao atualizar Usuario -- {ex}");
                return "Erro ao atualizar Usuario, contate o desenvolvedor";
            }
        }
    }
}
