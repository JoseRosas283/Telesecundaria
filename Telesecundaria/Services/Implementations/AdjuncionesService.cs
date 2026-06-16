using Telesecundaria.DTOs;
using Telesecundaria.DTOs.Adjunciones;
using Telesecundaria.Models;
using Telesecundaria.Repositories.Interfaces;
using Telesecundaria.Services.Interfaces;

namespace Telesecundaria.Services.Implementations
{
    public class AdjuncionesService : IAdjuncionesService
    {
        private readonly IAdjuncionesRepository _repository;
        private readonly IPdfService _pdfService;

        public AdjuncionesService(IAdjuncionesRepository repository, IPdfService pdfService)
        {
            _repository = repository;
            _pdfService = pdfService;
        }

        public async Task<AdjuncionResponseDTO> RegistrarAdjuncionAsync(AdjuncionRequestDTO dto)
        {
         
            if (string.IsNullOrWhiteSpace(dto.ClaveTutor))
                throw new ArgumentException("La clave del tutor es obligatoria.");
            if (string.IsNullOrWhiteSpace(dto.ClaveAspirante))
                throw new ArgumentException("La clave del aspirante es obligatoria.");

            // Lista de documentos recibidos alineandolo con el catálogo en la DB
            var documentos = new List<(IFormFile Archivo, string NombreTipo)>
            {
                (dto.ActaNacimiento,       "ACTA DE NACIMIENTO"),
                (dto.Curp,                 "CURP"),
                (dto.ComprobanteDomicilio, "COMPROBANTE DE DOMICILIO"),
                (dto.CertificadoPrimaria,  "CERTIFICADO DE PRIMARIA"),
                (dto.ConstanciaEstudios,   "CONSTANCIA DE ESTUDIOS VIGENTE")
            };

            // Valida que todos los archivos sean PDFs
            foreach (var (archivo, tipo) in documentos)
            {
                if (archivo == null || archivo.Length == 0)
                    throw new ArgumentException($"El documento '{tipo}' es obligatorio.");
                if (Path.GetExtension(archivo.FileName).ToLower() != ".pdf")
                    throw new ArgumentException($"El documento '{tipo}' debe ser un archivo PDF.");
            }

            // PASO 1 Crear la adjunción y obtener su clave
            var claveAdjuncion = await _repository.CrearAdjuncionAsync(dto.ClaveTutor, dto.ClaveAspirante);

            if (string.IsNullOrWhiteSpace(claveAdjuncion))
                throw new Exception("No se pudo generar la clave de adjunción.");

            // PASOS 2 y 3 por cada documento: guarda su PDF, va insertar a doc y luego su detalle
            var documentosRespuesta = new List<DocumentoAdjuntadoDTO>();

            foreach (var (archivo, nombreTipo) in documentos)
            {
                // Convierte el PDF a URL única por tipo
                var rutaUrl = await _pdfService.GuardarPdfAsync(archivo, nombreTipo);

                // Inserta en DocumentosAspirante y obtiene la clave
                var claveDoc = await _repository.InsertarDocumentoAspirante(rutaUrl, dto.ClaveAspirante, nombreTipo);

                // Inserta en DetalleAdjuncion
                await _repository.InsertarDetalleAdjuncionAsync(claveAdjuncion, claveDoc);

                documentosRespuesta.Add(new DocumentoAdjuntadoDTO
                {
                    ClaveDocAspirante = claveDoc,
                    TipoDocumento = nombreTipo,
                    RutaUrl = rutaUrl
                });
            }

            // Obtiene la adjunción completa para la respuesta
            var adjuncion = await _repository.ObtenerAdjuncionAsync(claveAdjuncion);

            return new AdjuncionResponseDTO
            {
                ClaveAdjuncion = claveAdjuncion,
                ClaveTutor = dto.ClaveTutor,
                ClaveAspirante = dto.ClaveAspirante,
                EstatusGral = adjuncion?.EstatusGral ?? "Pendiente",
                Documentos = documentosRespuesta
            };
        }
    }
}
