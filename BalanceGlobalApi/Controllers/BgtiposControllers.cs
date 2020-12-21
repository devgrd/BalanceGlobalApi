
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
    public class BgtiposController : ControllerBase
    {
        private readonly IBgtiposService _service;
        private readonly HttpCodeHelper _httpHelper;

        public BgtiposController(IBgtiposService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<BgtiposModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBgtipos()
        {
            return await _service.ReadBgtipos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgtiposModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetBgtipos(int id)
        {
            var _model = await _service.ReadBgtipos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgtiposModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutBgtipos(int id, BgtiposModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBgtipos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateBgtipos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgtiposModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostBgtipos(BgtiposModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateBgtipos(model, userName);
            var _model = _resp.Data as BgtiposModel;

            return _httpHelper.GetActionResult(_resp, "GetBgtipos", new { id = _model?.IdBgtipos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BgtiposModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteBgtipos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteBgtipos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

