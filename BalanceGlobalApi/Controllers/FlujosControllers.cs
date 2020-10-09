
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
    public class FlujosController : ControllerBase
    {
        private readonly IFlujosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public FlujosController(IFlujosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<FlujosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetFlujos()
        {
            return await _service.ReadFlujos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FlujosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetFlujos(int id)
        {
            var _model = await _service.ReadFlujos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FlujosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutFlujos(int id, FlujosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFlujos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateFlujos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FlujosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostFlujos(FlujosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateFlujos(model, userName);
            var _model = _resp.Data as FlujosModel;

            return _httpHelper.GetActionResult(_resp, "GetFlujos", new { id = _model?.IdFlujos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<FlujosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteFlujos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteFlujos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

