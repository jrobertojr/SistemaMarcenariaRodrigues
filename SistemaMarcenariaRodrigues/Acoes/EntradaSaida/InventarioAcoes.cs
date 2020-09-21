using SistemaMarcenariaRodrigues.Conexao;
using SistemaMarcenariaRodrigues.Log;
using System;
using System.Data;
using System.Globalization;

namespace SistemaMarcenariaRodrigues.Acoes.EntradaSaida
{
    class InventarioAcoes
    {
        private Conn Connection = new Conn();

        public int Seq(int produto)
        {
            try
            {
                string query = $@"
                    SELECT 
                        COUNT(*)
                    FROM inventario
                    WHERE produto = {produto}";

                DataTable tabela = Connection.SqlDataTable(query);
                return int.Parse(tabela.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar Seq -- {ex}");
                return 0;
            }
        }

        public string ValorTotal(double valorUnitario, int quantidade)
        {
            try
            {
                double valorTotal = valorUnitario * quantidade;
                return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorTotal);
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar Valor Total -- {ex}");
                return null;
            }
        }
    }
}
