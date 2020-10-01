
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaenasSistemasController : ControllerBase
    {
        private readonly IFaenasSistemasService _service;

        public FaenasSistemasController(IFaenasSistemasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaenasSistemasModel>>> GetFaenasSistemas()
        {
            return await _service.ReadFaenasSistemas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FaenasSistemasModel>> GetFaenasSistemas(int id)
        {
            var _model = await _service.ReadFaenasSistemas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaenasSistemas(int id, FaenasSistemasModel model)
        {
            if (id != model.IdFaenasSistemas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateFaenasSistemas(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadFaenasSistemas(id.ToString()) == null)
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
        public async Task<ActionResult<FaenasSistemasModel>> PostFaenasSistemas(FaenasSistemasModel model)
        {
            var _model = await _service.CreateFaenasSistemas(model);
            return CreatedAtAction("GetFaenasSistemas", new { id = _model.IdFaenasSistemas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FaenasSistemasModel>> DeleteFaenasSistemas(int id)
        {
            var _model = await _service.ReadFaenasSistemas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteFaenasSistemas(id.ToString());

            return _model;
        }

    }
}