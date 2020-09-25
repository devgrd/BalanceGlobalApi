
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
    public class PeriodosOperacionalesController : ControllerBase
    {
        private readonly IPeriodosOperacionalesService _service;

        public PeriodosOperacionalesController(IPeriodosOperacionalesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeriodosOperacionalesModel>>> GetPeriodosOperacionales()
        {
            return await _service.ReadPeriodosOperacionales();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeriodosOperacionalesModel>> GetPeriodosOperacionales(int id)
        {
            var _model = await _service.ReadPeriodosOperacionales(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodosOperacionales(int id, PeriodosOperacionalesModel model)
        {
            if (id != model.IdPeriodosOperacionales)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePeriodosOperacionales(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPeriodosOperacionales(id.ToString()) == null)
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
        public async Task<ActionResult<PeriodosOperacionalesModel>> PostPeriodosOperacionales(PeriodosOperacionalesModel model)
        {
            var _model = await _service.CreatePeriodosOperacionales(model);
            return CreatedAtAction("GetPeriodosOperacionales", new { id = _model.IdPeriodosOperacionales }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PeriodosOperacionalesModel>> DeletePeriodosOperacionales(int id)
        {
            var _model = await _service.ReadPeriodosOperacionales(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePeriodosOperacionales(id.ToString());

            return _model;
        }

    }
}