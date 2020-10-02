
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
    public class TipoPciController : ControllerBase
    {
        private readonly ITipoPciService _service;

        public TipoPciController(ITipoPciService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPciModel>>> GetTipoPci()
        {
            return await _service.ReadTipoPci();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TipoPciModel>> GetTipoPci(int id)
        {
            var _model = await _service.ReadTipoPci(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoPci(int id, TipoPciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoPci)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTipoPci(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTipoPci(id) == null)
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
        public async Task<ActionResult<TipoPciModel>> PostTipoPci(TipoPciModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTipoPci(model, userName);
            return CreatedAtAction("GetTipoPci", new { id = _model.IdTipoPci }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoPciModel>> DeleteTipoPci(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTipoPci(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTipoPci(id, userName);

            return _model;
        }

    }
}