
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
    public class TransSistemasCosechasController : ControllerBase
    {
        private readonly ITransSistemasCosechasService _service;

        public TransSistemasCosechasController(ITransSistemasCosechasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransSistemasCosechasModel>>> GetTransSistemasCosechas()
        {
            return await _service.ReadTransSistemasCosechas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransSistemasCosechasModel>> GetTransSistemasCosechas(int id)
        {
            var _model = await _service.ReadTransSistemasCosechas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransSistemasCosechas(int id, TransSistemasCosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTransSistemasCosechas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTransSistemasCosechas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTransSistemasCosechas(id) == null)
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
        public async Task<ActionResult<TransSistemasCosechasModel>> PostTransSistemasCosechas(TransSistemasCosechasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTransSistemasCosechas(model, userName);
            return CreatedAtAction("GetTransSistemasCosechas", new { id = _model.IdTransSistemasCosechas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TransSistemasCosechasModel>> DeleteTransSistemasCosechas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTransSistemasCosechas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTransSistemasCosechas(id, userName);

            return _model;
        }

    }
}