using Microsoft.AspNetCore.Mvc;
using Telesecundaria.DTOs;
using Telesecundaria.DTOs.Adjunciones;
using Telesecundaria.Services.Interfaces;

namespace Telesecundaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdjuncionesController : ControllerBase
    {
        private readonly IAdjuncionesService _service;

        public AdjuncionesController(IAdjuncionesService service)
        {
            _service = service;
        }

        [HttpPost("registrar")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> RegistrarAdjuncion([FromForm] AdjuncionRequestDTO dto)
        {
            try
            {
                var resultado = await _service.RegistrarAdjuncionAsync(dto);
                return StatusCode(201, resultado);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno del servidor.", detalle = ex.Message });
            }
        }
    }
}
