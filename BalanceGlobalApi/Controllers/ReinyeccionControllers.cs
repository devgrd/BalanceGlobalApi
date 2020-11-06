
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
    public class ReinyeccionController : ControllerBase
    {
        private readonly IReinyeccionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ReinyeccionController(IReinyeccionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ReinyeccionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetReinyeccionByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadReinyeccionByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetReinyeccion(int id)
        {
            var _model = await _service.ReadReinyeccion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutReinyeccion(int id, ReinyeccionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdReinyeccion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateReinyeccion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReinyeccionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostReinyeccion(ReinyeccionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateReinyeccion(model, userName);
            var _model = _resp.Data as ReinyeccionModel;

            return _httpHelper.GetActionResult(_resp, "GetReinyeccion", new { id = _model?.IdReinyeccion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteReinyeccion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteReinyeccion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

