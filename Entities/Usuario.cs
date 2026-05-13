namespace SistemadeVotaciones.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Curso { get; set; }

        public string Seccion { get; set; }

        public string Matricula { get; set; }

        public string UsuarioLogin { get; set; }

        public string Clave { get; set; }

        public string Rol { get; set; }

        public int PadronId { get; set; }

        public int? PlanchaId { get; set; }

        public bool HaVotado { get; set; }
    }
}