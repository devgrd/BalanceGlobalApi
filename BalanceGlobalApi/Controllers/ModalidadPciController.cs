
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
    public class ModalidadPciController : ControllerBase
    {
        private readonly IModalidadPciService _service;

        public ModalidadPciController(IModalidadPciService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModalidadPciModel>>> GetModalidadPci()
        {
            return await _service.ReadModalidadPci();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModalidadPciModel>> GetModalidadPci(int id)
        {
            var _model = await _service.ReadModalidadPci(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutModalidadPci(int id, ModalidadPciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdModalidadPci)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateModalidadPci(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadModalidadPci(id) == null)
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
        public async Task<ActionResult<ModalidadPciModel>> PostModalidadPci(ModalidadPciModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateModalidadPci(model, userName);
            return CreatedAtAction("GetModalidadPci", new { id = _model.IdModalidadPci }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ModalidadPciModel>> DeleteModalidadPci(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadModalidadPci(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteModalidadPci(id, userName);

            return _model;
        }

    }
}