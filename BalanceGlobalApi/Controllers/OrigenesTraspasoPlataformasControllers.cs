
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
    public class OrigenesTraspasoPlataformasController : ControllerBase
    {
        private readonly IOrigenesTraspasoPlataformasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public OrigenesTraspasoPlataformasController(IOrigenesTraspasoPlataformasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<OrigenesTraspasoPlataformasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetOrigenesTraspasoPlataformas()
        {
            return await _service.ReadOrigenesTraspasoPlataformas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesTraspasoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetOrigenesTraspasoPlataformas(int id)
        {
            var _model = await _service.ReadOrigenesTraspasoPlataformas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesTraspasoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutOrigenesTraspasoPlataformas(int id, OrigenesTraspasoPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdOrigenesTraspasoPlataformas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateOrigenesTraspasoPlataformas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesTraspasoPlataformasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostOrigenesTraspasoPlataformas(OrigenesTraspasoPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateOrigenesTraspasoPlataformas(model, userName);
            var _model = _resp.Data as OrigenesTraspasoPlataformasModel;

            return _httpHelper.GetActionResult(_resp, "GetOrigenesTraspasoPlataformas", new { id = _model?.IdOrigenesTraspasoPlataformas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesTraspasoPlataformasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteOrigenesTraspasoPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteOrigenesTraspasoPlataformas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

