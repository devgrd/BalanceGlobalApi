
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
    public class CorrienteGlobalController : ControllerBase
    {
        private readonly ICorrienteGlobalService _service;

        public CorrienteGlobalController(ICorrienteGlobalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CorrienteGlobalModel>>> GetCorrienteGlobal()
        {
            return await _service.ReadCorrienteGlobal();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CorrienteGlobalModel>> GetCorrienteGlobal(int id)
        {
            var _model = await _service.ReadCorrienteGlobal(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorrienteGlobal(int id, CorrienteGlobalModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrienteGlobal)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCorrienteGlobal(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCorrienteGlobal(id) == null)
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
        public async Task<ActionResult<CorrienteGlobalModel>> PostCorrienteGlobal(CorrienteGlobalModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCorrienteGlobal(model, userName);
            return CreatedAtAction("GetCorrienteGlobal", new { id = _model.IdCorrienteGlobal }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CorrienteGlobalModel>> DeleteCorrienteGlobal(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCorrienteGlobal(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCorrienteGlobal(id, userName);

            return _model;
        }

    }
}