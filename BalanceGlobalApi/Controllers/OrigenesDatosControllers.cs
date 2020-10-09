
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
    public class OrigenesDatosController : ControllerBase
    {
        private readonly IOrigenesDatosService _service;
        private readonly HttpCodeHelper _httpHelper;

        public OrigenesDatosController(IOrigenesDatosService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<OrigenesDatosModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetOrigenesDatos()
        {
            return await _service.ReadOrigenesDatos();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesDatosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetOrigenesDatos(int id)
        {
            var _model = await _service.ReadOrigenesDatos(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesDatosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutOrigenesDatos(int id, OrigenesDatosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdOrigenesDatos)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateOrigenesDatos(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesDatosModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostOrigenesDatos(OrigenesDatosModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateOrigenesDatos(model, userName);
            var _model = _resp.Data as OrigenesDatosModel;

            return _httpHelper.GetActionResult(_resp, "GetOrigenesDatos", new { id = _model?.IdOrigenesDatos });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<OrigenesDatosModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteOrigenesDatos(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteOrigenesDatos(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

