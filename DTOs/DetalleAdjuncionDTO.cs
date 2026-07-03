namespace Telesecundaria.DTOs
{
    public class DetalleAdjuncionDTO
    {
        public string ClaveAdjuncion { get; set; }
        public string ClaveDocAspirante { get; set; }
        public string EstatusDocumento { get; set; }
        public string MotivoRechazo { get; set; }
        public DateTime FechaEvaluacion { get; set; }
    }
}
