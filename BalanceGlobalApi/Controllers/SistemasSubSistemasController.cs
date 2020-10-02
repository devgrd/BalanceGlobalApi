
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
            var _model = await _service.ReadSistemasSubSistemas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemasSubSistemas(int id, SistemasSubSistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSistemasSubsistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSistemasSubSistemas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSistemasSubSistemas(id) == null)
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
        public async Task<ActionResult<SistemasSubSistemasModel>> PostSistemasSubSistemas(SistemasSubSistemasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateSistemasSubSistemas(model, userName);
            return CreatedAtAction("GetSistemasSubSistemas", new { id = _model.IdSistemasSubsistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SistemasSubSistemasModel>> DeleteSistemasSubSistemas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadSistemasSubSistemas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSistemasSubSistemas(id, userName);

            return _model;
        }

    }
}