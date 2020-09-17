using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarcenariaRodrigues.Model.Produtos
{
    class ProdutosModel
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Dimensoes { get; set; }
        public string Fornecedor { get; set; }
        public string Detalhe { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
    }
}
