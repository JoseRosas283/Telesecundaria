namespace Telesecundaria.DTOs
{
    public class TutoresAlumnosDTO
    {
        public string ClaveAlumno { get; set; }
        public string ClaveTutor { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
