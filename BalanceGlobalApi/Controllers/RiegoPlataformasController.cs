
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
    public class RiegoPlataformasController : ControllerBase
    {
        private readonly IRiegoPlataformasService _service;

        public RiegoPlataformasController(IRiegoPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RiegoPlataformasModel>>> GetRiegoPlataformas()
        {
            return await _service.ReadRiegoPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RiegoPlataformasModel>> GetRiegoPlataformas(int id)
        {
            var _model = await _service.ReadRiegoPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRiegoPlataformas(int id, RiegoPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdRiegoPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateRiegoPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadRiegoPlataformas(id) == null)
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
        public async Task<ActionResult<RiegoPlataformasModel>> PostRiegoPlataformas(RiegoPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateRiegoPlataformas(model, userName);
            return CreatedAtAction("GetRiegoPlataformas", new { id = _model.IdRiegoPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<RiegoPlataformasModel>> DeleteRiegoPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadRiegoPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteRiegoPlataformas(id, userName);

            return _model;
        }

    }
}