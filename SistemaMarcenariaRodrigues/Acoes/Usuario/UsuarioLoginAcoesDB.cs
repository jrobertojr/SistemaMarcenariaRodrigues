using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using SistemaMarcenariaRodrigues.Model.Usuario;
using System.Collections.Generic;
using System.Data;

namespace SistemaMarcenariaRodrigues.Acoes.Usuario
{
    class UsuarioLoginAcoesDB
    {
        private Conn Connection = new Conn();

        public List<UsuarioModel> Select(string login, int idUsuario)
        {
            try
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
                FROM usuario
                WHERE status = 1";

                if (login != null)
                {
                    query += $" AND usuario = '{login}' ";
                }
                if (idUsuario != 0)
                {
                    query += $" AND id = '{idUsuario}' ";
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
                        IdPrivilegio = (int)tabela.Rows[i]["privilegio"],
                        Status = (bool)tabela.Rows[i]["status"] == true ? "Ativo" : "Inativo",
                        Data = tabela.Rows[i]["data"].ToString(),
                    };
                    retorno.Add(usuarioModel);
                }
                return retorno;
            }
            catch (System.Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar valores login de usuario -- {ex}");
                return null;
            }
        }
    }
}
