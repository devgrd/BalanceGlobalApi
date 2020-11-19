
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using BalanceGlobal.Response;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IWorkflowItemService
    {
        Task<ApiResponse> CreateWorkflowItem(WorkflowItemModel WorkflowItemModel, string userName);
        Task<ApiResponse> ReadWorkflowItem();
        Task<ApiResponse> ReadWorkflowItemByUser(string email);
        Task<ApiResponse> UpdateWorkflowItem(WorkflowItemModel WorkflowItemModel, string userName);
        Task<ApiResponse> DeleteWorkflowItem(int id, string userName);
        Task<ApiResponse> ReadWorkflowItem(int id);
    }

    public class WorkflowItemService : IWorkflowItemService
    {
        private readonly IWorkflowItemRepository _repository;
        private readonly IMapper _mapper;

        public WorkflowItemService(IWorkflowItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ApiResponse> CreateWorkflowItem(WorkflowItemModel model, string userName)
        {
            try
            {
                var result = _mapper.Map<WorkflowItem>(model);
                await _repository.AddAsync(result, userName);
                model.IdWorkflowItem = result.IdWorkflowItem;

                return new ApiResponse(model, 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadWorkflowItem()
        {
            try
            {
                var data = await _repository.GetAllAsync();
                var result = _mapper.Map<List<WorkflowItemModel>>(data);

                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> UpdateWorkflowItem(WorkflowItemModel model, string userName)
        {
            try
            {
                var _model = await _repository.GetById(model.IdWorkflowItem);

                if (_model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<WorkflowItem>(model);
                await _repository.UpdateAsync(result, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> DeleteWorkflowItem(int id, string userName)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                await _repository.RemoveAsync(id, userName);

                return new ApiResponse("Ok", 200);
            }
            catch (DbUpdateException ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadWorkflowItem(int id)
        {
            try
            {
                var model = await _repository.GetById(id);

                if (model == null)
                {
                    return new ApiResponse("Not Found", 404);
                }

                var result = _mapper.Map<WorkflowItemModel>(model);

                return new ApiResponse(result, 200);

            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }
        }

        public async Task<ApiResponse> ReadWorkflowItemByUser(string email)
        {
            try
            {
                var data = await _repository.GetWorkFlowItemByUser(email);
                var result = _mapper.Map<List<WorkflowItemModel>>(data);
                return new ApiResponse(result, 200);
            }
            catch (Exception ex)
            {
                return new ApiResponse(ex.GetBaseException().Message, 409);
            }          
        }

        #endregion
    }
}

