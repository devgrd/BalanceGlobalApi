
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
    public class QuimicaPlataformasController : ControllerBase
    {
        private readonly IQuimicaPlataformasService _service;

        public QuimicaPlataformasController(IQuimicaPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuimicaPlataformasModel>>> GetQuimicaPlataformas()
        {
            return await _service.ReadQuimicaPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<QuimicaPlataformasModel>> GetQuimicaPlataformas(int id)
        {
            var _model = await _service.ReadQuimicaPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuimicaPlataformas(int id, QuimicaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdQuimicaPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateQuimicaPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadQuimicaPlataformas(id) == null)
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
        public async Task<ActionResult<QuimicaPlataformasModel>> PostQuimicaPlataformas(QuimicaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateQuimicaPlataformas(model, userName);
            return CreatedAtAction("GetQuimicaPlataformas", new { id = _model.IdQuimicaPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<QuimicaPlataformasModel>> DeleteQuimicaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadQuimicaPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteQuimicaPlataformas(id, userName);

            return _model;
        }

    }
}