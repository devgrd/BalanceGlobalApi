
using BalanceGlobal.Api.Helper;
using BalanceGlobal.Models;
using BalanceGlobal.Response;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermeabilidadController : ControllerBase
    {
        private readonly IPermeabilidadService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PermeabilidadController(IPermeabilidadService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PermeabilidadModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPermeabilidad()
        {
            return await _service.ReadPermeabilidad();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PermeabilidadModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPermeabilidad(int id)
        {
            var _model = await _service.ReadPermeabilidad(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PermeabilidadModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPermeabilidad(int id, PermeabilidadModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPermeabilidad)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePermeabilidad(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PermeabilidadModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPermeabilidad(PermeabilidadModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePermeabilidad(model, userName);
            var _model = _resp.Data as PermeabilidadModel;

            return _httpHelper.GetActionResult(_resp, "GetPermeabilidad", new { id = _model?.IdPermeabilidad });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PermeabilidadModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePermeabilidad(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePermeabilidad(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

