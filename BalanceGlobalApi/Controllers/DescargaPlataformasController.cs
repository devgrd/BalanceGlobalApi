
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
    public class DescargaPlataformasController : ControllerBase
    {
        private readonly IDescargaPlataformasService _service;

        public DescargaPlataformasController(IDescargaPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DescargaPlataformasModel>>> GetDescargaPlataformas()
        {
            return await _service.ReadDescargaPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DescargaPlataformasModel>> GetDescargaPlataformas(int id)
        {
            var _model = await _service.ReadDescargaPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDescargaPlataformas(int id, DescargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDescargaPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateDescargaPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadDescargaPlataformas(id) == null)
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
        public async Task<ActionResult<DescargaPlataformasModel>> PostDescargaPlataformas(DescargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateDescargaPlataformas(model, userName);
            return CreatedAtAction("GetDescargaPlataformas", new { id = _model.IdDescargaPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DescargaPlataformasModel>> DeleteDescargaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadDescargaPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteDescargaPlataformas(id, userName);

            return _model;
        }

    }
}