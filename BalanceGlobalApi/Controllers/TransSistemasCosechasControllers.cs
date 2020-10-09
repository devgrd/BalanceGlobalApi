
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
    public class TransSistemasCosechasController : ControllerBase
    {
        private readonly ITransSistemasCosechasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TransSistemasCosechasController(ITransSistemasCosechasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TransSistemasCosechasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTransSistemasCosechas()
        {
            return await _service.ReadTransSistemasCosechas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TransSistemasCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTransSistemasCosechas(int id)
        {
            var _model = await _service.ReadTransSistemasCosechas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TransSistemasCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTransSistemasCosechas(int id, TransSistemasCosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTransSistemasCosechas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTransSistemasCosechas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TransSistemasCosechasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTransSistemasCosechas(TransSistemasCosechasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTransSistemasCosechas(model, userName);
            var _model = _resp.Data as TransSistemasCosechasModel;

            return _httpHelper.GetActionResult(_resp, "GetTransSistemasCosechas", new { id = _model?.IdTransSistemasCosechas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TransSistemasCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTransSistemasCosechas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTransSistemasCosechas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

