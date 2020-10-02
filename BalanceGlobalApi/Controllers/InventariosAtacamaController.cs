
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
    public class InventariosAtacamaController : ControllerBase
    {
        private readonly IInventariosAtacamaService _service;

        public InventariosAtacamaController(IInventariosAtacamaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventariosAtacamaModel>>> GetInventariosAtacama()
        {
            return await _service.ReadInventariosAtacama();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InventariosAtacamaModel>> GetInventariosAtacama(int id)
        {
            var _model = await _service.ReadInventariosAtacama(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventariosAtacama(int id, InventariosAtacamaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdInventariosAtacama)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateInventariosAtacama(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadInventariosAtacama(id) == null)
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
        public async Task<ActionResult<InventariosAtacamaModel>> PostInventariosAtacama(InventariosAtacamaModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateInventariosAtacama(model, userName);
            return CreatedAtAction("GetInventariosAtacama", new { id = _model.IdInventariosAtacama }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<InventariosAtacamaModel>> DeleteInventariosAtacama(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadInventariosAtacama(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteInventariosAtacama(id, userName);

            return _model;
        }

    }
}