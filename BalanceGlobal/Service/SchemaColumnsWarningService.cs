
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
        Task<SchemaColumnsWarningModel> CreateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel);
        Task<List<SchemaColumnsWarningModel>> ReadSchemaColumnsWarning();
        Task UpdateSchemaColumnsWarning(SchemaColumnsWarningModel SchemaColumnsWarningModel);
        Task DeleteSchemaColumnsWarning(string id);
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

        public async Task<SchemaColumnsWarningModel> CreateSchemaColumnsWarning(SchemaColumnsWarningModel model)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(model);
            await _repository.AddAsync(result);
            model.IdSchemaColumnsWarning = result.IdSchemaColumnsWarning;
            return model;
        }

        public async Task<List<SchemaColumnsWarningModel>> ReadSchemaColumnsWarning()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsWarningModel>>(data);

            return result;
        }

        public async Task UpdateSchemaColumnsWarning(SchemaColumnsWarningModel model)
        {
            var result = _mapper.Map<SchemaColumnsWarning>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSchemaColumnsWarning(string id)
        {
            await _repository.RemoveAsync(id);
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