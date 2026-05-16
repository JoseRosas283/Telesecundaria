namespace Telesecundaria.DTOs
{
    public class CitasInscripcionDTO
    {
        public string ClaveCita { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string EstadoCita { get; set; }
        public string Observaciones { get; set; }
        public DateTime CreateAt { get; set; }
        public string ClaveRevision { get; set; }
        public string ClaveTutorAspirante { get; set; }
    }
}
