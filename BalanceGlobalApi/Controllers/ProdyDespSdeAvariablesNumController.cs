
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
    public class ProdyDespSdeAvariablesNumController : ControllerBase
    {
        private readonly IProdyDespSdeAvariablesNumService _service;

        public ProdyDespSdeAvariablesNumController(IProdyDespSdeAvariablesNumService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdyDespSdeAvariablesNumModel>>> GetProdyDespSdeAvariablesNum()
        {
            return await _service.ReadProdyDespSdeAvariablesNum();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdyDespSdeAvariablesNumModel>> GetProdyDespSdeAvariablesNum(int id)
        {
            var _model = await _service.ReadProdyDespSdeAvariablesNum(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdyDespSdeAvariablesNum(int id, ProdyDespSdeAvariablesNumModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAvariablesNum)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateProdyDespSdeAvariablesNum(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadProdyDespSdeAvariablesNum(id) == null)
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
        public async Task<ActionResult<ProdyDespSdeAvariablesNumModel>> PostProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateProdyDespSdeAvariablesNum(model, userName);
            return CreatedAtAction("GetProdyDespSdeAvariablesNum", new { id = _model.IdProdyDespSdeAvariablesNum }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdyDespSdeAvariablesNumModel>> DeleteProdyDespSdeAvariablesNum(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadProdyDespSdeAvariablesNum(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteProdyDespSdeAvariablesNum(id, userName);

            return _model;
        }

    }
}