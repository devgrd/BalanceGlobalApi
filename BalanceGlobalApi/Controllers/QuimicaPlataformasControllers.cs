
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
    public class QuimicaPlataformasController : ControllerBase
    {
        private readonly IQuimicaPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public QuimicaPlataformasController(IQuimicaPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<QuimicaPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetQuimicaPlataformas()
        {
            return await _service.ReadQuimicaPlataformas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<QuimicaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetQuimicaPlataformas(int id)
        {
            var _model = await _service.ReadQuimicaPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<QuimicaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutQuimicaPlataformas(int id, QuimicaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdQuimicaPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateQuimicaPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<QuimicaPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostQuimicaPlataformas(QuimicaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateQuimicaPlataformas(model, userName);
            var _model = _resp.Data as QuimicaPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetQuimicaPlataformas", new { id = _model?.IdQuimicaPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<QuimicaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteQuimicaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteQuimicaPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

