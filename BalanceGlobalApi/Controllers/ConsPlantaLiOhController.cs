
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
    public class ConsPlantaLiOhController : ControllerBase
    {
        private readonly IConsPlantaLiOhService _service;

        public ConsPlantaLiOhController(IConsPlantaLiOhService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsPlantaLiOhModel>>> GetConsPlantaLiOh()
        {
            return await _service.ReadConsPlantaLiOh();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsPlantaLiOhModel>> GetConsPlantaLiOh(int id)
        {
            var _model = await _service.ReadConsPlantaLiOh(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsPlantaLiOh(int id, ConsPlantaLiOhModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsPlantaLiOh)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsPlantaLiOh(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsPlantaLiOh(id) == null)
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
        public async Task<ActionResult<ConsPlantaLiOhModel>> PostConsPlantaLiOh(ConsPlantaLiOhModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsPlantaLiOh(model, userName);
            return CreatedAtAction("GetConsPlantaLiOh", new { id = _model.IdConsPlantaLiOh }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsPlantaLiOhModel>> DeleteConsPlantaLiOh(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsPlantaLiOh(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsPlantaLiOh(id, userName);

            return _model;
        }

    }
}