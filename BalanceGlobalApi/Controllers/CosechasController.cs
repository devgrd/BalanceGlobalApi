
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
    public class CosechasController : ControllerBase
    {
        private readonly ICosechasService _service;

        public CosechasController(ICosechasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CosechasModel>>> GetCosechas()
        {
            return await _service.ReadCosechas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CosechasModel>> GetCosechas(int id)
        {
            var _model = await _service.ReadCosechas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCosechas(int id, CosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCosechas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCosechas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCosechas(id) == null)
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
        public async Task<ActionResult<CosechasModel>> PostCosechas(CosechasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCosechas(model, userName);
            return CreatedAtAction("GetCosechas", new { id = _model.IdCosechas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CosechasModel>> DeleteCosechas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCosechas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCosechas(id, userName);

            return _model;
        }

    }
}