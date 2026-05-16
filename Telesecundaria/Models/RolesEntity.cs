namespace Telesecundaria.Models
{
    public class RolesEntity
    {
        public string ClaveRol { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }

        // Colecciones
        public ICollection<EmpleadoRolEntity> EmpleadoRoles { get; set; } = new List<EmpleadoRolEntity>();
    }
}
