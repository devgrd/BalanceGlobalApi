
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
    public class PcimodosController : ControllerBase
    {
        private readonly IPcimodosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PcimodosController(IPcimodosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PcimodosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPcimodosByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadPcimodosByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PcimodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPcimodos(int id)
        {
            var _model = await _service.ReadPcimodos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PcimodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPcimodos(int id, PcimodosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPcimodos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePcimodos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PcimodosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPcimodos(PcimodosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePcimodos(model, userName);
            var _model = _resp.Data as PcimodosModel;

            return _httpHelper.GetActionResult(_resp, "GetPcimodos", new { id = _model?.IdPcimodos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PcimodosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePcimodos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePcimodos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

