using System.Text.Json.Serialization;

namespace Telesecundaria.Models
{
    public class AsignacionGrupoEntity
    {
        public string ClaveAsignacion { get; set; }
        public string ClaveAlumno { get; set; }
        public string ClaveGrupo { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string CicloEscolar { get; set; }

        // Navegación
        [JsonIgnore]
        public virtual AlumnosEntity Alumno { get; set; }
        [JsonIgnore]
        public virtual GruposEntity Grupo { get; set; }
    }
}
