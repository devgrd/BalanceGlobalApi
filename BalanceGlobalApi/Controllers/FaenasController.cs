
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BalanceGlobal.Response;

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
        public async Task<ActionResult<ApiResponse>> GetFaenas()
        {
            return await _service.ReadFaenas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse>> GetFaenas(int id)
        {
            var _model = await _service.ReadFaenas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse>> PutFaenas(int id, FaenasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFaenas)
            {
                return BadRequest();
            }

            var result = await _service.UpdateFaenas(model, userName);

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostFaenas(FaenasModel model, [Required][FromHeader] string userName)
        {
            var _model = (await _service.CreateFaenas(model, userName)).Data as FaenasModel;
            return CreatedAtAction("GetFaenas", new { id = _model.IdFaenas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteFaenas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadFaenas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteFaenas(id, userName);

            return _model;
        }

    }
}