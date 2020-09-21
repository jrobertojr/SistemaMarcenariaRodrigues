namespace SistemaMarcenariaRodrigues.Model
{
    class InventarioModel
    {
        public int Id { get; set; }
        public int Produto { get; set; }
        public string NomeProduto { get; set; }
        public int Operacao { get; set; }
        public string NomeOperacao { get; set; }
        public int Quantidade { get; set; }
        public string ValorEntrada { get; set; }
        public string ValorTotal { get; set; }
        public string Serie { get; set; }
        public string NotaFiscal { get; set; }
        public string Fornecedor { get; set; }
        public string Complemento { get; set; }
        public int Seq { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
    }
}
