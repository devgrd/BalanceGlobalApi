
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
    public class CategoriaConsumoAguaController : ControllerBase
    {
        private readonly ICategoriaConsumoAguaService _service;

        public CategoriaConsumoAguaController(ICategoriaConsumoAguaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaConsumoAguaModel>>> GetCategoriaConsumoAgua()
        {
            return await _service.ReadCategoriaConsumoAgua();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaConsumoAguaModel>> GetCategoriaConsumoAgua(int id)
        {
            var _model = await _service.ReadCategoriaConsumoAgua(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaConsumoAgua(int id, CategoriaConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCategoriaConsumoAgua)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCategoriaConsumoAgua(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCategoriaConsumoAgua(id) == null)
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
        public async Task<ActionResult<CategoriaConsumoAguaModel>> PostCategoriaConsumoAgua(CategoriaConsumoAguaModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCategoriaConsumoAgua(model, userName);
            return CreatedAtAction("GetCategoriaConsumoAgua", new { id = _model.IdCategoriaConsumoAgua }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriaConsumoAguaModel>> DeleteCategoriaConsumoAgua(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCategoriaConsumoAgua(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCategoriaConsumoAgua(id, userName);

            return _model;
        }

    }
}