
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
    public class BombasController : ControllerBase
    {
        private readonly IBombasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public BombasController(IBombasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<BombasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetBombas()
        {
            return await _service.ReadBombas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BombasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetBombas(int id)
        {
            var _model = await _service.ReadBombas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BombasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutBombas(int id, BombasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBombas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateBombas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BombasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostBombas(BombasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateBombas(model, userName);
            var _model = _resp.Data as BombasModel;

            return _httpHelper.GetActionResult(_resp, "GetBombas", new { id = _model?.IdBombas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<BombasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteBombas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteBombas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

