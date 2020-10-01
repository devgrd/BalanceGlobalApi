
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfraestructurasController : ControllerBase
    {
        private readonly IInfraestructurasService _service;

        public InfraestructurasController(IInfraestructurasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfraestructurasModel>>> GetInfraestructuras()
        {
            return await _service.ReadInfraestructuras();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InfraestructurasModel>> GetInfraestructuras(int id)
        {
            var _model = await _service.ReadInfraestructuras(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfraestructuras(int id, InfraestructurasModel model)
        {
            if (id != model.IdInfraestructuras)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateInfraestructuras(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadInfraestructuras(id.ToString()) == null)
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
        public async Task<ActionResult<InfraestructurasModel>> PostInfraestructuras(InfraestructurasModel model)
        {
            var _model = await _service.CreateInfraestructuras(model);
            return CreatedAtAction("GetInfraestructuras", new { id = _model.IdInfraestructuras }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<InfraestructurasModel>> DeleteInfraestructuras(int id)
        {
            var _model = await _service.ReadInfraestructuras(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteInfraestructuras(id.ToString());

            return _model;
        }

    }
}