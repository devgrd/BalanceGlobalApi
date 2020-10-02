
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
    public class ConsLi2Co3Controller : ControllerBase
    {
        private readonly IConsLi2Co3Service _service;

        public ConsLi2Co3Controller(IConsLi2Co3Service service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsLi2Co3Model>>> GetConsLi2Co3()
        {
            return await _service.ReadConsLi2Co3();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsLi2Co3Model>> GetConsLi2Co3(int id)
        {
            var _model = await _service.ReadConsLi2Co3(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsLi2Co3(int id, ConsLi2Co3Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsLi2Co3)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsLi2Co3(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsLi2Co3(id) == null)
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
        public async Task<ActionResult<ConsLi2Co3Model>> PostConsLi2Co3(ConsLi2Co3Model model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsLi2Co3(model, userName);
            return CreatedAtAction("GetConsLi2Co3", new { id = _model.IdConsLi2Co3 }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsLi2Co3Model>> DeleteConsLi2Co3(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsLi2Co3(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsLi2Co3(id, userName);

            return _model;
        }

    }
}