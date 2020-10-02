
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
    public class PermeabilidadController : ControllerBase
    {
        private readonly IPermeabilidadService _service;

        public PermeabilidadController(IPermeabilidadService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PermeabilidadModel>>> GetPermeabilidad()
        {
            return await _service.ReadPermeabilidad();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PermeabilidadModel>> GetPermeabilidad(int id)
        {
            var _model = await _service.ReadPermeabilidad(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPermeabilidad(int id, PermeabilidadModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPermeabilidad)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePermeabilidad(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPermeabilidad(id) == null)
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
        public async Task<ActionResult<PermeabilidadModel>> PostPermeabilidad(PermeabilidadModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePermeabilidad(model, userName);
            return CreatedAtAction("GetPermeabilidad", new { id = _model.IdPermeabilidad }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PermeabilidadModel>> DeletePermeabilidad(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPermeabilidad(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePermeabilidad(id, userName);

            return _model;
        }

    }
}