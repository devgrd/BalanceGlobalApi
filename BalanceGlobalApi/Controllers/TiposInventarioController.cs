
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
    public class TiposInventarioController : ControllerBase
    {
        private readonly ITiposInventarioService _service;

        public TiposInventarioController(ITiposInventarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiposInventarioModel>>> GetTiposInventario()
        {
            return await _service.ReadTiposInventario();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TiposInventarioModel>> GetTiposInventario(int id)
        {
            var _model = await _service.ReadTiposInventario(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposInventario(int id, TiposInventarioModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTiposInventario)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTiposInventario(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTiposInventario(id) == null)
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
        public async Task<ActionResult<TiposInventarioModel>> PostTiposInventario(TiposInventarioModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTiposInventario(model, userName);
            return CreatedAtAction("GetTiposInventario", new { id = _model.IdTiposInventario }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TiposInventarioModel>> DeleteTiposInventario(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTiposInventario(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTiposInventario(id, userName);

            return _model;
        }

    }
}