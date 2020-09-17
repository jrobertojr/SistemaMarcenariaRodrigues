using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMarcenariaRodrigues.Acoes.Usuario
{
    class UsuarioAcoesDB
    {
        private Conn Connection = new Conn();

        public List<UsuarioModel> Select(string login = null, int idUsuario = 0)
        {
            List<UsuarioModel> retorno = new List<UsuarioModel>();

            string query = $@"
                SELECT 
                    id,
                    usuario,
                    senha,
                    nome,
                    email,
                    privilegio,
                    status,
                    data
                FROM usuario";

            if (login != null)
            {
                query += $" WHERE usuario = '{login}'";
            }
            if (idUsuario != 0)
            {
                query += $" WHERE id = '{idUsuario}'";
            }

            DataTable tabela = Connection.SqlDataTable(query);

            if (tabela.Rows.Count <= 0)
            {
                return null;
            }

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                UsuarioModel usuarioModel = new UsuarioModel()
                {
                    Id = (int)tabela.Rows[i]["id"],
                    Usuario = tabela.Rows[i]["usuario"].ToString(),
                    Senha = tabela.Rows[i]["senha"].ToString(),
                    Nome = tabela.Rows[i]["nome"].ToString(),
                    Email = tabela.Rows[i]["email"].ToString(),
                    Privilegio = tabela.Rows[i]["privilegio"].ToString(),
                    Status = (bool)tabela.Rows[i]["status"],
                    Data = tabela.Rows[i]["data"].ToString(),
                };
                retorno.Add(usuarioModel);
            }
            return retorno;
        }
    }
}
