
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
            var _model = await _service.ReadOrigenesDatos(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigenesDatos(int id, OrigenesDatosModel model)
        {
            if (id != model.IdOrigenesDatos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateOrigenesDatos(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadOrigenesDatos(id.ToString()) == null)
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
        public async Task<ActionResult<OrigenesDatosModel>> PostOrigenesDatos(OrigenesDatosModel model)
        {
            var _model = await _service.CreateOrigenesDatos(model);
            return CreatedAtAction("GetOrigenesDatos", new { id = _model.IdOrigenesDatos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrigenesDatosModel>> DeleteOrigenesDatos(int id)
        {
            var _model = await _service.ReadOrigenesDatos(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteOrigenesDatos(id.ToString());

            return _model;
        }

    }
}