
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescargaInfraestructurasDestinoController : ControllerBase
    {
        private readonly IDescargaInfraestructurasDestinoService _service;

        public DescargaInfraestructurasDestinoController(IDescargaInfraestructurasDestinoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DescargaInfraestructurasDestinoModel>>> GetDescargaInfraestructurasDestino()
        {
            return await _service.ReadDescargaInfraestructurasDestino();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DescargaInfraestructurasDestinoModel>> GetDescargaInfraestructurasDestino(int id)
        {
            var _model = await _service.ReadDescargaInfraestructurasDestino(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDescargaInfraestructurasDestino(int id, DescargaInfraestructurasDestinoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDescargaInfraestructurasDestino)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateDescargaInfraestructurasDestino(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadDescargaInfraestructurasDestino(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<DescargaInfraestructurasDestinoModel>> PostDescargaInfraestructurasDestino(DescargaInfraestructurasDestinoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateDescargaInfraestructurasDestino(model, userName);
            return CreatedAtAction("GetDescargaInfraestructurasDestino", new { id = _model.IdDescargaInfraestructurasDestino }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DescargaInfraestructurasDestinoModel>> DeleteDescargaInfraestructurasDestino(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadDescargaInfraestructurasDestino(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteDescargaInfraestructurasDestino(id, userName);

            return _model;
        }

    }
}