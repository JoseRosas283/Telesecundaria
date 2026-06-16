using Telesecundaria.DTOs;
using Telesecundaria.DTOs.Adjunciones;
using Telesecundaria.Models;

namespace Telesecundaria.Services.Interfaces
{
    public interface IAdjuncionesService
    {
        Task<AdjuncionResponseDTO> RegistrarAdjuncionAsync(AdjuncionRequestDTO dto);
    }
}
