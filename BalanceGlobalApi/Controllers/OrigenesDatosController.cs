
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
    public class OrigenesDatosController : ControllerBase
    {
        private readonly IOrigenesDatosService _service;

        public OrigenesDatosController(IOrigenesDatosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrigenesDatosModel>>> GetOrigenesDatos()
        {
            return await _service.ReadOrigenesDatos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrigenesDatosModel>> GetOrigenesDatos(int id)
        {
            var _model = await _service.ReadOrigenesDatos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigenesDatos(int id, OrigenesDatosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdOrigenesDatos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateOrigenesDatos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadOrigenesDatos(id) == null)
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
        public async Task<ActionResult<OrigenesDatosModel>> PostOrigenesDatos(OrigenesDatosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateOrigenesDatos(model, userName);
            return CreatedAtAction("GetOrigenesDatos", new { id = _model.IdOrigenesDatos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrigenesDatosModel>> DeleteOrigenesDatos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadOrigenesDatos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteOrigenesDatos(id, userName);

            return _model;
        }

    }
}