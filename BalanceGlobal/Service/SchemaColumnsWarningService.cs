
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaColumnsWarningService
    {
        Task<SchemaColumnsWarningModel> CreateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel, string userName);
        Task<List<SchemaColumnsWarningModel>> ReadSchemaColumnsWarning();
        Task UpdateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel, string userName);
        Task DeleteSchemaColumnsWarning(string id, string userName);
        Task<SchemaColumnsWarningModel> ReadSchemaColumnsWarning(string id);
    }
    public class SchemaColumnsWarningService : ISchemaColumnsWarningService
    {
        private readonly ISchemaColumnsWarningRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsWarningService(ISchemaColumnsWarningRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SchemaColumnsWarningModel> CreateSchemaColumnsWarning(SchemaColumnsWarningModel model, string userName)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(model);
            await _repository.AddAsync(result, userName);
            model.IdSchemaColumnsWarning = result.IdSchemaColumnsWarning;
            return model;
        }

        public async Task<List<SchemaColumnsWarningModel>> ReadSchemaColumnsWarning()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsWarningModel>>(data);

            return result;
        }

        public async Task UpdateSchemaColumnsWarning(SchemaColumnsWarningModel model, string userName)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteSchemaColumnsWarning(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<SchemaColumnsWarningModel> ReadSchemaColumnsWarning(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SchemaColumnsWarningModel>(model);
            return result;
        }

        #endregion
    }
}