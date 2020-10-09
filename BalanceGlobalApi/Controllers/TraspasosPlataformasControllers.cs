
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
    public class TraspasosPlataformasController : ControllerBase
    {
        private readonly ITraspasosPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TraspasosPlataformasController(ITraspasosPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TraspasosPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTraspasosPlataformas()
        {
            return await _service.ReadTraspasosPlataformas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TraspasosPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTraspasosPlataformas(int id)
        {
            var _model = await _service.ReadTraspasosPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TraspasosPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTraspasosPlataformas(int id, TraspasosPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTraspasosPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTraspasosPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TraspasosPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTraspasosPlataformas(TraspasosPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTraspasosPlataformas(model, userName);
            var _model = _resp.Data as TraspasosPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetTraspasosPlataformas", new { id = _model?.IdTraspasosPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TraspasosPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTraspasosPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTraspasosPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

