
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
    public class ModalidadPlantasController : ControllerBase
    {
        private readonly IModalidadPlantasService _service;

        public ModalidadPlantasController(IModalidadPlantasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModalidadPlantasModel>>> GetModalidadPlantas()
        {
            return await _service.ReadModalidadPlantas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModalidadPlantasModel>> GetModalidadPlantas(int id)
        {
            var _model = await _service.ReadModalidadPlantas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutModalidadPlantas(int id, ModalidadPlantasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdModalidadPlantas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateModalidadPlantas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadModalidadPlantas(id) == null)
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
        public async Task<ActionResult<ModalidadPlantasModel>> PostModalidadPlantas(ModalidadPlantasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateModalidadPlantas(model, userName);
            return CreatedAtAction("GetModalidadPlantas", new { id = _model.IdModalidadPlantas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ModalidadPlantasModel>> DeleteModalidadPlantas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadModalidadPlantas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteModalidadPlantas(id, userName);

            return _model;
        }

    }
}