
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
    public class ImpregnacionSistemaRefController : ControllerBase
    {
        private readonly IImpregnacionSistemaRefService _service;

        public ImpregnacionSistemaRefController(IImpregnacionSistemaRefService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImpregnacionSistemaRefModel>>> GetImpregnacionSistemaRef()
        {
            return await _service.ReadImpregnacionSistemaRef();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImpregnacionSistemaRefModel>> GetImpregnacionSistemaRef(int id)
        {
            var _model = await _service.ReadImpregnacionSistemaRef(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImpregnacionSistemaRef(int id, ImpregnacionSistemaRefModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImpregnacionSistemaRef)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImpregnacionSistemaRef(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImpregnacionSistemaRef(id) == null)
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
        public async Task<ActionResult<ImpregnacionSistemaRefModel>> PostImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImpregnacionSistemaRef(model, userName);
            return CreatedAtAction("GetImpregnacionSistemaRef", new { id = _model.IdImpregnacionSistemaRef }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImpregnacionSistemaRefModel>> DeleteImpregnacionSistemaRef(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImpregnacionSistemaRef(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImpregnacionSistemaRef(id, userName);

            return _model;
        }

    }
}