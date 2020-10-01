
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
    public class ConsumoEnergeticoController : ControllerBase
    {
        private readonly IConsumoEnergeticoService _service;

        public ConsumoEnergeticoController(IConsumoEnergeticoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumoEnergeticoModel>>> GetConsumoEnergetico()
        {
            return await _service.ReadConsumoEnergetico();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumoEnergeticoModel>> GetConsumoEnergetico(int id)
        {
            var _model = await _service.ReadConsumoEnergetico(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumoEnergetico(int id, ConsumoEnergeticoModel model)
        {
            if (id != model.IdConsumoEnergetico)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsumoEnergetico(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsumoEnergetico(id.ToString()) == null)
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
        public async Task<ActionResult<ConsumoEnergeticoModel>> PostConsumoEnergetico(ConsumoEnergeticoModel model)
        {
            var _model = await _service.CreateConsumoEnergetico(model);
            return CreatedAtAction("GetConsumoEnergetico", new { id = _model.IdConsumoEnergetico }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsumoEnergeticoModel>> DeleteConsumoEnergetico(int id)
        {
            var _model = await _service.ReadConsumoEnergetico(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsumoEnergetico(id.ToString());

            return _model;
        }

    }
}