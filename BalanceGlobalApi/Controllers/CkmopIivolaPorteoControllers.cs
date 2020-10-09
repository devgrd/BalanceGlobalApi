
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
    public class CkmopIivolaPorteoController : ControllerBase
    {
        private readonly ICkmopIivolaPorteoService _service;
        private readonly HttpCodeHelper _httpHelper;

        public CkmopIivolaPorteoController(ICkmopIivolaPorteoService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<CkmopIivolaPorteoModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetCkmopIivolaPorteo()
        {
            return await _service.ReadCkmopIivolaPorteo();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIivolaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetCkmopIivolaPorteo(int id)
        {
            var _model = await _service.ReadCkmopIivolaPorteo(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIivolaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutCkmopIivolaPorteo(int id, CkmopIivolaPorteoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCkmopIivolaPorteo)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateCkmopIivolaPorteo(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIivolaPorteoModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostCkmopIivolaPorteo(CkmopIivolaPorteoModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateCkmopIivolaPorteo(model, userName);
            var _model = _resp.Data as CkmopIivolaPorteoModel;

            return _httpHelper.GetActionResult(_resp, "GetCkmopIivolaPorteo", new { id = _model?.IdCkmopIivolaPorteo });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<CkmopIivolaPorteoModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteCkmopIivolaPorteo(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteCkmopIivolaPorteo(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

