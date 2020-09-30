
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
    public class TipoInfraestructurasController : ControllerBase
    {
        private readonly ITipoInfraestructurasService _service;

        public TipoInfraestructurasController(ITipoInfraestructurasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoInfraestructurasModel>>> GetTipoInfraestructuras()
        {
            return await _service.ReadTipoInfraestructuras();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoInfraestructurasModel>> GetTipoInfraestructuras(int id)
        {
            var _model = await _service.ReadTipoInfraestructuras(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoInfraestructuras(int id, TipoInfraestructurasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoInfraestructuras)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTipoInfraestructuras(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTipoInfraestructuras(id.ToString()) == null)
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
        public async Task<ActionResult<TipoInfraestructurasModel>> PostTipoInfraestructuras(TipoInfraestructurasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTipoInfraestructuras(model, userName);
            return CreatedAtAction("GetTipoInfraestructuras", new { id = _model.IdTipoInfraestructuras }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoInfraestructurasModel>> DeleteTipoInfraestructuras(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTipoInfraestructuras(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTipoInfraestructuras(id.ToString(), userName);

            return _model;
        }

    }
}