
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
    public class FaenasController : ControllerBase
    {
        private readonly IFaenasService _service;

        public FaenasController(IFaenasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaenasModel>>> GetFaenas()
        {
            return await _service.ReadFaenas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FaenasModel>> GetFaenas(int id)
        {
            var _model = await _service.ReadFaenas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaenas(int id, FaenasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFaenas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateFaenas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadFaenas(id.ToString()) == null)
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
        public async Task<ActionResult<FaenasModel>> PostFaenas(FaenasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateFaenas(model, userName);
            return CreatedAtAction("GetFaenas", new { id = _model.IdFaenas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FaenasModel>> DeleteFaenas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadFaenas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteFaenas(id.ToString(), userName);

            return _model;
        }

    }
}