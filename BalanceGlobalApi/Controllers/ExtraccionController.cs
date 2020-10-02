
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
    public class ExtraccionController : ControllerBase
    {
        private readonly IExtraccionService _service;

        public ExtraccionController(IExtraccionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtraccionModel>>> GetExtraccion()
        {
            return await _service.ReadExtraccion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExtraccionModel>> GetExtraccion(int id)
        {
            var _model = await _service.ReadExtraccion(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraccion(int id, ExtraccionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdExtraccion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateExtraccion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadExtraccion(id) == null)
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
        public async Task<ActionResult<ExtraccionModel>> PostExtraccion(ExtraccionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateExtraccion(model, userName);
            return CreatedAtAction("GetExtraccion", new { id = _model.IdExtraccion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ExtraccionModel>> DeleteExtraccion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadExtraccion(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteExtraccion(id, userName);

            return _model;
        }

    }
}