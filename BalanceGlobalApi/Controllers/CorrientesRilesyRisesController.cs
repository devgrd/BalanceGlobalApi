
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
    public class CorrientesRilesyRisesController : ControllerBase
    {
        private readonly ICorrientesRilesyRisesService _service;

        public CorrientesRilesyRisesController(ICorrientesRilesyRisesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CorrientesRilesyRisesModel>>> GetCorrientesRilesyRises()
        {
            return await _service.ReadCorrientesRilesyRises();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CorrientesRilesyRisesModel>> GetCorrientesRilesyRises(int id)
        {
            var _model = await _service.ReadCorrientesRilesyRises(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorrientesRilesyRises(int id, CorrientesRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrientesRilesyRises)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCorrientesRilesyRises(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCorrientesRilesyRises(id) == null)
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
        public async Task<ActionResult<CorrientesRilesyRisesModel>> PostCorrientesRilesyRises(CorrientesRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCorrientesRilesyRises(model, userName);
            return CreatedAtAction("GetCorrientesRilesyRises", new { id = _model.IdCorrientesRilesyRises }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CorrientesRilesyRisesModel>> DeleteCorrientesRilesyRises(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCorrientesRilesyRises(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCorrientesRilesyRises(id, userName);

            return _model;
        }

    }
}