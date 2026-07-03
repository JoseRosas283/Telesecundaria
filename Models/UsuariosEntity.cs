using System.Text.Json.Serialization;

namespace Telesecundaria.Models
{
    public class UsuariosEntity
    {
        public string ClaveUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string? CorreoInstitucional { get; set; }
        public bool Estado { get; set; } = true;
        public string ClaveEmpleado { get; set; }

        // Navegación
        [JsonIgnore]
        public virtual EmpleadosEntity? Empleado { get; set; }

        // Colecciones
        [JsonIgnore]
        public ICollection<PublicacionesEntity> Publicaciones { get; set; } = new List<PublicacionesEntity>();
        [JsonIgnore]
        public ICollection<RevisionesEntity> Revisiones { get; set; } = new List<RevisionesEntity>();
        [JsonIgnore]
        public ICollection<ReceptoresEntity> Receptores { get; set; } = new List<ReceptoresEntity>();
        [JsonIgnore]
        public ICollection<EntregasEntity> Entregas { get; set; } = new List<EntregasEntity>();

        [JsonIgnore]
        public ICollection<LogueosEntity> Logueos { get; set; } = new List<LogueosEntity>();
    }
}
