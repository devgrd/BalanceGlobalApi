
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
    public class DescargaPlataformasController : ControllerBase
    {
        private readonly IDescargaPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public DescargaPlataformasController(IDescargaPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<DescargaPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetDescargaPlataformas()
        {
            return await _service.ReadDescargaPlataformas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetDescargaPlataformas(int id)
        {
            var _model = await _service.ReadDescargaPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutDescargaPlataformas(int id, DescargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDescargaPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateDescargaPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostDescargaPlataformas(DescargaPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateDescargaPlataformas(model, userName);
            var _model = _resp.Data as DescargaPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetDescargaPlataformas", new { id = _model?.IdDescargaPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DescargaPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteDescargaPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteDescargaPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

