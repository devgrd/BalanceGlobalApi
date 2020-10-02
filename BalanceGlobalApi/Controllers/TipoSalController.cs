
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
    public class TipoSalController : ControllerBase
    {
        private readonly ITipoSalService _service;

        public TipoSalController(ITipoSalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoSalModel>>> GetTipoSal()
        {
            return await _service.ReadTipoSal();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoSalModel>> GetTipoSal(int id)
        {
            var _model = await _service.ReadTipoSal(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoSal(int id, TipoSalModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoSal)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTipoSal(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTipoSal(id) == null)
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
        public async Task<ActionResult<TipoSalModel>> PostTipoSal(TipoSalModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTipoSal(model, userName);
            return CreatedAtAction("GetTipoSal", new { id = _model.IdTipoSal }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoSalModel>> DeleteTipoSal(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTipoSal(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTipoSal(id, userName);

            return _model;
        }

    }
}