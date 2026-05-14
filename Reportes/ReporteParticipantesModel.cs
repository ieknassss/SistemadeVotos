namespace SistemadeVotaciones.Reportes
{
    public class ReporteParticipantesModel
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string UsuarioLogin { get; set; }

        public string Rol { get; set; }

        public bool HaVotado { get; set; }
    }
}