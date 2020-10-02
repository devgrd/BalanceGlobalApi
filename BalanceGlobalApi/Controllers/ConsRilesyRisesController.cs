
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
    public class ConsRilesyRisesController : ControllerBase
    {
        private readonly IConsRilesyRisesService _service;

        public ConsRilesyRisesController(IConsRilesyRisesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsRilesyRisesModel>>> GetConsRilesyRises()
        {
            return await _service.ReadConsRilesyRises();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsRilesyRisesModel>> GetConsRilesyRises(int id)
        {
            var _model = await _service.ReadConsRilesyRises(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsRilesyRises(int id, ConsRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsRilesyRises)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsRilesyRises(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsRilesyRises(id) == null)
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
        public async Task<ActionResult<ConsRilesyRisesModel>> PostConsRilesyRises(ConsRilesyRisesModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsRilesyRises(model, userName);
            return CreatedAtAction("GetConsRilesyRises", new { id = _model.IdConsRilesyRises }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsRilesyRisesModel>> DeleteConsRilesyRises(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsRilesyRises(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsRilesyRises(id, userName);

            return _model;
        }

    }
}