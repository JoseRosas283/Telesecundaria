namespace Telesecundaria.DTOs
{
    public class ConvocatoriasDTO
    {
        public string ClaveConvocatoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string CicloEscolar { get; set; }
        public int? CupoMaximo { get; set; }
        public int? CupoDisponible { get; set; }
        public bool Activacion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
