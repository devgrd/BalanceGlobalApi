
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
    public class ConsLitioLiCo3mensualController : ControllerBase
    {
        private readonly IConsLitioLiCo3mensualService _service;

        public ConsLitioLiCo3mensualController(IConsLitioLiCo3mensualService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsLitioLiCo3mensualModel>>> GetConsLitioLiCo3mensual()
        {
            return await _service.ReadConsLitioLiCo3mensual();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsLitioLiCo3mensualModel>> GetConsLitioLiCo3mensual(int id)
        {
            var _model = await _service.ReadConsLitioLiCo3mensual(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsLitioLiCo3mensual(int id, ConsLitioLiCo3mensualModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsLitioLiCo3mensual)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsLitioLiCo3mensual(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsLitioLiCo3mensual(id) == null)
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
        public async Task<ActionResult<ConsLitioLiCo3mensualModel>> PostConsLitioLiCo3mensual(ConsLitioLiCo3mensualModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsLitioLiCo3mensual(model, userName);
            return CreatedAtAction("GetConsLitioLiCo3mensual", new { id = _model.IdConsLitioLiCo3mensual }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsLitioLiCo3mensualModel>> DeleteConsLitioLiCo3mensual(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsLitioLiCo3mensual(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsLitioLiCo3mensual(id, userName);

            return _model;
        }

    }
}