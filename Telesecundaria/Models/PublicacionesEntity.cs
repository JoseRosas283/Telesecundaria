using System.Text.Json.Serialization;

namespace Telesecundaria.Models
{
    public class PublicacionesEntity
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
        public bool Destacado { get; set; } = false;
        public bool EstatusVisible { get; set; } = true;

        // Navegación
        [JsonIgnore]
        public virtual UsuariosEntity Usuario { get; set; }
        [JsonIgnore]
        public virtual ConvocatoriasEntity Convocatoria { get; set; }
        [JsonIgnore]
        public virtual GaleriaImagenesEntity GaleriaImagen { get; set; }
    }
}
