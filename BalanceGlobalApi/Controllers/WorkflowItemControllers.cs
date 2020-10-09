
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
    public class WorkflowItemController : ControllerBase
    {
        private readonly IWorkflowItemService _service;
        private readonly HttpCodeHelper _httpHelper;

        public WorkflowItemController(IWorkflowItemService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<WorkflowItemModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetWorkflowItem()
        {
            return await _service.ReadWorkflowItem();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<WorkflowItemModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetWorkflowItem(int id)
        {
            var _model = await _service.ReadWorkflowItem(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<WorkflowItemModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutWorkflowItem(int id, WorkflowItemModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdWorkflowItem)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateWorkflowItem(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<WorkflowItemModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostWorkflowItem(WorkflowItemModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateWorkflowItem(model, userName);
            var _model = _resp.Data as WorkflowItemModel;

            return _httpHelper.GetActionResult(_resp, "GetWorkflowItem", new { id = _model?.IdWorkflowItem });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<WorkflowItemModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteWorkflowItem(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteWorkflowItem(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

