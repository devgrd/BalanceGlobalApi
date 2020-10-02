
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
    public class PcimodosController : ControllerBase
    {
        private readonly IPcimodosService _service;

        public PcimodosController(IPcimodosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PcimodosModel>>> GetPcimodos()
        {
            return await _service.ReadPcimodos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PcimodosModel>> GetPcimodos(int id)
        {
            var _model = await _service.ReadPcimodos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPcimodos(int id, PcimodosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPcimodos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePcimodos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPcimodos(id) == null)
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
        public async Task<ActionResult<PcimodosModel>> PostPcimodos(PcimodosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePcimodos(model, userName);
            return CreatedAtAction("GetPcimodos", new { id = _model.IdPcimodos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PcimodosModel>> DeletePcimodos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPcimodos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePcimodos(id, userName);

            return _model;
        }

    }
}