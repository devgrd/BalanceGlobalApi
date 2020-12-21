
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
    public class BgcorrientesController : ControllerBase
    {
        private readonly IBgcorrientesService _service;
        private readonly HttpCodeHelper _httpHelper;

        public BgcorrientesController(IBgcorrientesService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<BgcorrientesModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBgcorrientes()
        {
            return await _service.ReadBgcorrientes();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgcorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetBgcorrientes(int id)
        {
            var _model = await _service.ReadBgcorrientes(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgcorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutBgcorrientes(int id, BgcorrientesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBgcorrientes)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateBgcorrientes(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgcorrientesModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostBgcorrientes(BgcorrientesModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateBgcorrientes(model, userName);
            var _model = _resp.Data as BgcorrientesModel;

            return _httpHelper.GetActionResult(_resp, "GetBgcorrientes", new { id = _model?.IdBgcorrientes });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgcorrientesModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteBgcorrientes(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteBgcorrientes(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

