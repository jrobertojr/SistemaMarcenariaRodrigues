using MySql.Data.MySqlClient;
using SistemaMarcenariaRodrigues.Log;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaMarcenariaRodrigues.Conexao
{
    class Conn
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Contrutor
        public Conn()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            try
            {
                string connectionString;

                server = "";
                database = "";
                uid = "";
                password = "";
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão, contate o Administrador");
                RegistraLog.Log($"Erro ao gerar string de conexão --- {ex}");
            }

        }

        //Abrir Conexão
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar ao banco de dados.  Contate o administrador");
                        RegistraLog.Log($"Erro ao conecatr com o banco de dados --- {ex}");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        RegistraLog.Log($"Erro 1045 --- {ex}");
                        break;
                }
                return false;
            }
        }

        //Fechar Conexão
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de Conexão");
                RegistraLog.Log($"Erro ao fechar conexão --- {ex}");
                return false;
            }
        }

        //Metodo para ação ativa
        public void Sql(String SQLq)
        {
            try
            {
                string query = SQLq;

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível estabelecer conexão");
                RegistraLog.Log($"Erro ao executar comando MySQL --- Query: {SQLq} --- {ex}");
            }

        }

        //Metodo para ação passiva
        public DataTable SqlDataTable(String SQLq)
        {
            string query = SQLq;
            DataTable dTable = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandTimeout = 99999;

                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                adap.Fill(dTable);

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível estabelecer conexão");
                RegistraLog.Log($"Erro ao retornar dados para o DataTable --- Query: {SQLq} --- {ex}");
            }
            return dTable;
        }

    }
}
