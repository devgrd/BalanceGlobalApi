
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
    public class SubSistemasController : ControllerBase
    {
        private readonly ISubSistemasService _service;

        public SubSistemasController(ISubSistemasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubSistemasModel>>> GetSubSistemas()
        {
            return await _service.ReadSubSistemas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubSistemasModel>> GetSubSistemas(int id)
        {
            var _model = await _service.ReadSubSistemas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubSistemas(int id, SubSistemasModel model)
        {
            if (id != model.IdSubSistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSubSistemas(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSubSistemas(id.ToString()) == null)
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
        public async Task<ActionResult<SubSistemasModel>> PostSubSistemas(SubSistemasModel model)
        {
            var _model = await _service.CreateSubSistemas(model);
            return CreatedAtAction("GetSubSistemas", new { id = _model.IdSubSistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SubSistemasModel>> DeleteSubSistemas(int id)
        {
            var _model = await _service.ReadSubSistemas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSubSistemas(id.ToString());

            return _model;
        }

    }
}