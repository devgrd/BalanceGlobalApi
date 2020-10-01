
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
    public class SistemasSubSistemasController : ControllerBase
    {
        private readonly ISistemasSubSistemasService _service;

        public SistemasSubSistemasController(ISistemasSubSistemasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SistemasSubSistemasModel>>> GetSistemasSubSistemas()
        {
            return await _service.ReadSistemasSubSistemas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SistemasSubSistemasModel>> GetSistemasSubSistemas(int id)
        {
            var _model = await _service.ReadSistemasSubSistemas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemasSubSistemas(int id, SistemasSubSistemasModel model)
        {
            if (id != model.IdSistemasSubSistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSistemasSubSistemas(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSistemasSubSistemas(id.ToString()) == null)
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
        public async Task<ActionResult<SistemasSubSistemasModel>> PostSistemasSubSistemas(SistemasSubSistemasModel model)
        {
            var _model = await _service.CreateSistemasSubSistemas(model);
            return CreatedAtAction("GetSistemasSubSistemas", new { id = _model.IdSistemasSubSistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SistemasSubSistemasModel>> DeleteSistemasSubSistemas(int id)
        {
            var _model = await _service.ReadSistemasSubSistemas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSistemasSubSistemas(id.ToString());

            return _model;
        }

    }
}