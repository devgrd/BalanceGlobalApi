
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
    public class ReservoriosController : ControllerBase
    {
        private readonly IReservoriosService _service;

        public ReservoriosController(IReservoriosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservoriosModel>>> GetReservorios()
        {
            return await _service.ReadReservorios();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReservoriosModel>> GetReservorios(int id)
        {
            var _model = await _service.ReadReservorios(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservorios(int id, ReservoriosModel model)
        {
            if (id != model.IdReservorios)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateReservorios(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadReservorios(id.ToString()) == null)
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
        public async Task<ActionResult<ReservoriosModel>> PostReservorios(ReservoriosModel model)
        {
            var _model = await _service.CreateReservorios(model);
            return CreatedAtAction("GetReservorios", new { id = _model.IdReservorios }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ReservoriosModel>> DeleteReservorios(int id)
        {
            var _model = await _service.ReadReservorios(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteReservorios(id.ToString());

            return _model;
        }

    }
}