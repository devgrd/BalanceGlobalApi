
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
    public class TasaEvaporacionController : ControllerBase
    {
        private readonly ITasaEvaporacionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TasaEvaporacionController(ITasaEvaporacionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TasaEvaporacionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTasaEvaporacion()
        {
            return await _service.ReadTasaEvaporacion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TasaEvaporacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTasaEvaporacion(int id)
        {
            var _model = await _service.ReadTasaEvaporacion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TasaEvaporacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTasaEvaporacion(int id, TasaEvaporacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTasaEvaporacion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTasaEvaporacion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TasaEvaporacionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTasaEvaporacion(TasaEvaporacionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTasaEvaporacion(model, userName);
            var _model = _resp.Data as TasaEvaporacionModel;

            return _httpHelper.GetActionResult(_resp, "GetTasaEvaporacion", new { id = _model?.IdTasaEvaporacion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TasaEvaporacionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTasaEvaporacion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTasaEvaporacion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

