
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
    public class ConsInvCarmenController : ControllerBase
    {
        private readonly IConsInvCarmenService _service;

        public ConsInvCarmenController(IConsInvCarmenService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsInvCarmenModel>>> GetConsInvCarmen()
        {
            return await _service.ReadConsInvCarmen();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsInvCarmenModel>> GetConsInvCarmen(int id)
        {
            var _model = await _service.ReadConsInvCarmen(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsInvCarmen(int id, ConsInvCarmenModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsInvCarmen)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsInvCarmen(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsInvCarmen(id) == null)
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
        public async Task<ActionResult<ConsInvCarmenModel>> PostConsInvCarmen(ConsInvCarmenModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsInvCarmen(model, userName);
            return CreatedAtAction("GetConsInvCarmen", new { id = _model.IdConsInvCarmen }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsInvCarmenModel>> DeleteConsInvCarmen(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsInvCarmen(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsInvCarmen(id, userName);

            return _model;
        }

    }
}