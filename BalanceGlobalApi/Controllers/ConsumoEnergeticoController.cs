
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
        public async Task<IActionResult> PutConsumoEnergetico(int id, ConsumoEnergeticoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsumoEnergetico)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsumoEnergetico(model, userName);
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
        public async Task<ActionResult<ConsumoEnergeticoModel>> PostConsumoEnergetico(ConsumoEnergeticoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsumoEnergetico(model, userName);
            return CreatedAtAction("GetConsumoEnergetico", new { id = _model.IdConsumoEnergetico }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsumoEnergeticoModel>> DeleteConsumoEnergetico(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsumoEnergetico(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsumoEnergetico(id.ToString(), userName);

            return _model;
        }

    }
}