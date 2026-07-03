namespace Telesecundaria.DTOs
{
    public class AspirantesDTO
    {
        public string ClaveAspirante { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public string EscuelaProcedencia { get; set; }
        public decimal PromedioPrimaria { get; set; }
        public bool TieneDiscapacidad { get; set; }
        public string NombreEnfermedad { get; set; }
        public bool HermanoPlantel { get; set; }
        public string CurpHermano { get; set; }
        public string EstatusAspirante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public string ClaveConvocatoria { get; set; }
        public string ClaveTutorAspirante { get; set; }
    }
}
