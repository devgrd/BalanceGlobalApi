
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
    public class OrigenesTraspasoPlataformasController : ControllerBase
    {
        private readonly IOrigenesTraspasoPlataformasService _service;

        public OrigenesTraspasoPlataformasController(IOrigenesTraspasoPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrigenesTraspasoPlataformasModel>>> GetOrigenesTraspasoPlataformas()
        {
            return await _service.ReadOrigenesTraspasoPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrigenesTraspasoPlataformasModel>> GetOrigenesTraspasoPlataformas(int id)
        {
            var _model = await _service.ReadOrigenesTraspasoPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigenesTraspasoPlataformas(int id, OrigenesTraspasoPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdIdOrigenesTraspasoPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateOrigenesTraspasoPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadOrigenesTraspasoPlataformas(id) == null)
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
        public async Task<ActionResult<OrigenesTraspasoPlataformasModel>> PostOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateOrigenesTraspasoPlataformas(model, userName);
            return CreatedAtAction("GetOrigenesTraspasoPlataformas", new { id = _model.IdIdOrigenesTraspasoPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrigenesTraspasoPlataformasModel>> DeleteOrigenesTraspasoPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadOrigenesTraspasoPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteOrigenesTraspasoPlataformas(id, userName);

            return _model;
        }

    }
}