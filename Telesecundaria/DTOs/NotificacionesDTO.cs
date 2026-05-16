namespace Telesecundaria.DTOs
{
    public class NotificacionesDTO
    {
        public string ClaveNotificacion { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public short Prioridad { get; set; }
        public string Datos { get; set; }
        public bool Visualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string ClaveTipoNotificacion { get; set; }
        public string ClaveReceptor { get; set; }
    }
}
