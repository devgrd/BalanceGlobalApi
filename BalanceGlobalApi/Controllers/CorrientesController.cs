
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
    public class CorrientesController : ControllerBase
    {
        private readonly ICorrientesService _service;

        public CorrientesController(ICorrientesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CorrientesModel>>> GetCorrientes()
        {
            return await _service.ReadCorrientes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CorrientesModel>> GetCorrientes(int id)
        {
            var _model = await _service.ReadCorrientes(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorrientes(int id, CorrientesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientes)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCorrientes(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCorrientes(id) == null)
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
        public async Task<ActionResult<CorrientesModel>> PostCorrientes(CorrientesModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCorrientes(model, userName);
            return CreatedAtAction("GetCorrientes", new { id = _model.IdCorrientes }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CorrientesModel>> DeleteCorrientes(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCorrientes(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCorrientes(id, userName);

            return _model;
        }

    }
}