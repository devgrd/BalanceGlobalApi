
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemasController : ControllerBase
    {
        private readonly ISistemasService _service;

        public SistemasController(ISistemasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SistemasModel>>> GetSistemas()
        {
            return await _service.ReadSistemas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SistemasModel>> GetSistemas(int id)
        {
            var _model = await _service.ReadSistemas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemas(int id, SistemasModel model)
        {
            if (id != model.IdSistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSistemas(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSistemas(id.ToString()) == null)
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
        public async Task<ActionResult<SistemasModel>> PostSistemas(SistemasModel model)
        {
            var _model = await _service.CreateSistemas(model);
            return CreatedAtAction("GetSistemas", new { id = _model.IdSistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SistemasModel>> DeleteSistemas(int id)
        {
            var _model = await _service.ReadSistemas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSistemas(id.ToString());

            return _model;
        }

    }
}