
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
    public class CargaPlataformasController : ControllerBase
    {
        private readonly ICargaPlataformasService _service;

        public CargaPlataformasController(ICargaPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CargaPlataformasModel>>> GetCargaPlataformas()
        {
            return await _service.ReadCargaPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CargaPlataformasModel>> GetCargaPlataformas(int id)
        {
            var _model = await _service.ReadCargaPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCargaPlataformas(int id, CargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCargaPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCargaPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCargaPlataformas(id) == null)
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
        public async Task<ActionResult<CargaPlataformasModel>> PostCargaPlataformas(CargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCargaPlataformas(model, userName);
            return CreatedAtAction("GetCargaPlataformas", new { id = _model.IdCargaPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CargaPlataformasModel>> DeleteCargaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCargaPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCargaPlataformas(id, userName);

            return _model;
        }

    }
}