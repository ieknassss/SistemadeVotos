namespace SistemadeVotaciones.Entities
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Curso { get; set; }
        public string Foto { get; set; }
        public int PlanchaId { get; set; }
    }
}