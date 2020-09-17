using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarcenariaRodrigues.Model.Usuario
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Privilegio { get; set; }
        public bool Status { get; set; }
        public string Data { get; set; }
    }
}
