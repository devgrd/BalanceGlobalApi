
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
    public class ConsDespachoController : ControllerBase
    {
        private readonly IConsDespachoService _service;

        public ConsDespachoController(IConsDespachoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsDespachoModel>>> GetConsDespacho()
        {
            return await _service.ReadConsDespacho();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsDespachoModel>> GetConsDespacho(int id)
        {
            var _model = await _service.ReadConsDespacho(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsDespacho(int id, ConsDespachoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsDespacho)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsDespacho(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsDespacho(id) == null)
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
        public async Task<ActionResult<ConsDespachoModel>> PostConsDespacho(ConsDespachoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsDespacho(model, userName);
            return CreatedAtAction("GetConsDespacho", new { id = _model.IdConsDespacho }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsDespachoModel>> DeleteConsDespacho(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsDespacho(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsDespacho(id, userName);

            return _model;
        }

    }
}