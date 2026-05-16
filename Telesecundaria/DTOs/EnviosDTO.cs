namespace Telesecundaria.DTOs
{
    public class EnviosDTO
    {
        public string ClaveEnvio { get; set; }
        public string ClaveNotificacion { get; set; }
        public string Destino { get; set; }
        public int ReintentoNum { get; set; }
        public string Estatus { get; set; }
        public bool ConfirmacionLectura { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string ErrorLog { get; set; }
    }
}
