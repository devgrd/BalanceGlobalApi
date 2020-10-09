
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
    public class CosechasController : ControllerBase
    {
        private readonly ICosechasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CosechasController(ICosechasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CosechasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCosechas()
        {
            return await _service.ReadCosechas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCosechas(int id)
        {
            var _model = await _service.ReadCosechas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCosechas(int id, CosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCosechas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCosechas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CosechasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCosechas(CosechasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCosechas(model, userName);
            var _model = _resp.Data as CosechasModel;

            return _httpHelper.GetActionResult(_resp, "GetCosechas", new { id = _model?.IdCosechas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCosechas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCosechas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

