
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
    public class ConsumoAguaController : ControllerBase
    {
        private readonly IConsumoAguaService _service;

        public ConsumoAguaController(IConsumoAguaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumoAguaModel>>> GetConsumoAgua()
        {
            return await _service.ReadConsumoAgua();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumoAguaModel>> GetConsumoAgua(int id)
        {
            var _model = await _service.ReadConsumoAgua(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsumoAgua(int id, ConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsumoAgua)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsumoAgua(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsumoAgua(id) == null)
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
        public async Task<ActionResult<ConsumoAguaModel>> PostConsumoAgua(ConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsumoAgua(model, userName);
            return CreatedAtAction("GetConsumoAgua", new { id = _model.IdConsumoAgua }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsumoAguaModel>> DeleteConsumoAgua(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsumoAgua(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsumoAgua(id, userName);

            return _model;
        }

    }
}