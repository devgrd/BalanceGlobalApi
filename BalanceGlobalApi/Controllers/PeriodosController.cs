
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
    public class PeriodosController : ControllerBase
    {
        private readonly IPeriodosService _service;

        public PeriodosController(IPeriodosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeriodosModel>>> GetPeriodos()
        {
            return await _service.ReadPeriodos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeriodosModel>> GetPeriodos(int id)
        {
            var _model = await _service.ReadPeriodos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodos(int id, PeriodosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPeriodos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePeriodos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPeriodos(id) == null)
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
        public async Task<ActionResult<PeriodosModel>> PostPeriodos(PeriodosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePeriodos(model, userName);
            return CreatedAtAction("GetPeriodos", new { id = _model.IdPeriodos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PeriodosModel>> DeletePeriodos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPeriodos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePeriodos(id, userName);

            return _model;
        }

    }
}