namespace SistemaMarcenariaRodrigues.Model.Usuario
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int IdPrivilegio { get; set; }
        public string Privilegio { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
    }
}
