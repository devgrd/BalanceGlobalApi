
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
    public class PorteosController : ControllerBase
    {
        private readonly IPorteosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PorteosController(IPorteosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PorteosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPorteosByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadPorteosByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PorteosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPorteos(int id)
        {
            var _model = await _service.ReadPorteos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PorteosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPorteos(int id, PorteosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPorteos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePorteos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PorteosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPorteos(PorteosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePorteos(model, userName);
            var _model = _resp.Data as PorteosModel;

            return _httpHelper.GetActionResult(_resp, "GetPorteos", new { id = _model?.IdPorteos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PorteosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePorteos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePorteos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

