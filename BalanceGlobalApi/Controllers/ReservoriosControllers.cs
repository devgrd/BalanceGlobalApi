
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
    public class ReservoriosController : ControllerBase
    {
        private readonly IReservoriosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ReservoriosController(IReservoriosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ReservoriosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetReservorios()
        {
            return await _service.ReadReservorios();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReservoriosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetReservorios(int id)
        {
            var _model = await _service.ReadReservorios(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReservoriosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutReservorios(int id, ReservoriosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdReservorios)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateReservorios(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReservoriosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostReservorios(ReservoriosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateReservorios(model, userName);
            var _model = _resp.Data as ReservoriosModel;

            return _httpHelper.GetActionResult(_resp, "GetReservorios", new { id = _model?.IdReservorios });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReservoriosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteReservorios(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteReservorios(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

