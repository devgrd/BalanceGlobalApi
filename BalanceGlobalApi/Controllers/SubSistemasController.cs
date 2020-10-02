
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
            var _model = await _service.ReadSubSistemas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubSistemas(int id, SubSistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSubSistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSubSistemas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSubSistemas(id) == null)
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
        public async Task<ActionResult<SubSistemasModel>> PostSubSistemas(SubSistemasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateSubSistemas(model, userName);
            return CreatedAtAction("GetSubSistemas", new { id = _model.IdSubSistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SubSistemasModel>> DeleteSubSistemas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadSubSistemas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSubSistemas(id, userName);

            return _model;
        }

    }
}