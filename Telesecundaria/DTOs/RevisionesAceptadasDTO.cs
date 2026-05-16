namespace Telesecundaria.DTOs
{
    public class RevisionesAceptadasDTO
    {
        public string ClaveRevisionAceptada { get; set; }
        public string ClaveRevision { get; set; }
        public string ClaveReceptor { get; set; }
        public string ClaveConvocatoria { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public bool Estado { get; set; }
    }
}
