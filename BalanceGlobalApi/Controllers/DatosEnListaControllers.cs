
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
    public class DatosEnListaController : ControllerBase
    {
        private readonly IDatosEnListaService _service;
        private readonly HttpCodeHelper _httpHelper;

        public DatosEnListaController(IDatosEnListaService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<DatosEnListaModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetDatosEnLista()
        {
            return await _service.ReadDatosEnLista();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DatosEnListaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetDatosEnLista(int id)
        {
            var _model = await _service.ReadDatosEnLista(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DatosEnListaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutDatosEnLista(int id, DatosEnListaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDatosEnLista)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateDatosEnLista(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DatosEnListaModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostDatosEnLista(DatosEnListaModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateDatosEnLista(model, userName);
            var _model = _resp.Data as DatosEnListaModel;

            return _httpHelper.GetActionResult(_resp, "GetDatosEnLista", new { id = _model?.IdDatosEnLista });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<DatosEnListaModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteDatosEnLista(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteDatosEnLista(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

