
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
    public class ExtraccionAguaController : ControllerBase
    {
        private readonly IExtraccionAguaService _service;

        public ExtraccionAguaController(IExtraccionAguaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtraccionAguaModel>>> GetExtraccionAgua()
        {
            return await _service.ReadExtraccionAgua();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExtraccionAguaModel>> GetExtraccionAgua(int id)
        {
            var _model = await _service.ReadExtraccionAgua(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraccionAgua(int id, ExtraccionAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdExtraccionAgua)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateExtraccionAgua(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadExtraccionAgua(id) == null)
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
        public async Task<ActionResult<ExtraccionAguaModel>> PostExtraccionAgua(ExtraccionAguaModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateExtraccionAgua(model, userName);
            return CreatedAtAction("GetExtraccionAgua", new { id = _model.IdExtraccionAgua }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ExtraccionAguaModel>> DeleteExtraccionAgua(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadExtraccionAgua(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteExtraccionAgua(id, userName);

            return _model;
        }

    }
}