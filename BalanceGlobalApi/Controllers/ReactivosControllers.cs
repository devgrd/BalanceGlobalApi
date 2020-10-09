
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
    public class ReactivosController : ControllerBase
    {
        private readonly IReactivosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ReactivosController(IReactivosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ReactivosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetReactivos()
        {
            return await _service.ReadReactivos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetReactivos(int id)
        {
            var _model = await _service.ReadReactivos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutReactivos(int id, ReactivosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdReactivos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateReactivos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReactivosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostReactivos(ReactivosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateReactivos(model, userName);
            var _model = _resp.Data as ReactivosModel;

            return _httpHelper.GetActionResult(_resp, "GetReactivos", new { id = _model?.IdReactivos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReactivosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteReactivos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteReactivos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

