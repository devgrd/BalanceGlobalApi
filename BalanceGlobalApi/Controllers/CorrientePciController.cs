
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
    public class CorrientePciController : ControllerBase
    {
        private readonly ICorrientePciService _service;

        public CorrientePciController(ICorrientePciService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CorrientePciModel>>> GetCorrientePci()
        {
            return await _service.ReadCorrientePci();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CorrientePciModel>> GetCorrientePci(int id)
        {
            var _model = await _service.ReadCorrientePci(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorrientePci(int id, CorrientePciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientePci)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCorrientePci(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCorrientePci(id) == null)
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
        public async Task<ActionResult<CorrientePciModel>> PostCorrientePci(CorrientePciModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCorrientePci(model, userName);
            return CreatedAtAction("GetCorrientePci", new { id = _model.IdCorrientePci }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CorrientePciModel>> DeleteCorrientePci(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCorrientePci(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCorrientePci(id, userName);

            return _model;
        }

    }
}