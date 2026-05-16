namespace Telesecundaria.DTOs
{
    public class PublicacionesDTO
    {
        public string ClavePublicacion { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string CuerpoContenido { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaAparicion { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public string ClaveUsuario { get; set; }
        public string ClaveConvocatoria { get; set; }
        public string ClaveImagen { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Destacado { get; set; }
        public bool EstatusVisible { get; set; }
    }
}
