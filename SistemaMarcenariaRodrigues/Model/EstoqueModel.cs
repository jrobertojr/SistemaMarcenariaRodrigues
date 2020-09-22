namespace SistemaMarcenariaRodrigues.Model
{
    class EstoqueModel
    {
        public int Codigo { get; set; }
        public int IdOperacao { get; set; }
        public string TipoMovimento { get; set; }
        public string Data { get; set; }
        public int Quantidade { get; set; }
        public string Valor { get; set; }
        public string OperacaoFiscal { get; set; }
        public string Serie { get; set; }
        public string Notafiscal { get; set; }
        public string FornecedorCliente { get; set; }
        public string Complemento { get; set; }
        public string ValorMovimento { get; set; }
        public int QuantidadeTotal { get; set; }
        public string ValorTotal { get; set; }
        public string CustoMedio { get; set; }
    }
}
