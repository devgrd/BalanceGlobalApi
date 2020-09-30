
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaDefService
    {
        Task<SchemaDefModel> CreateSchemaDef(SchemaDefModel SchemaDefModel, string userName);
        Task<List<SchemaDefModel>> ReadSchemaDef();
        Task UpdateSchemaDef(SchemaDefModel SchemaDefModel, string userName);
        Task DeleteSchemaDef(string id, string userName);
        Task<SchemaDefModel> ReadSchemaDef(string id);
    }
    public class SchemaDefService : ISchemaDefService
    {
        private readonly ISchemaDefRepository _repository;
        private readonly IMapper _mapper;

        public SchemaDefService(ISchemaDefRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SchemaDefModel> CreateSchemaDef(SchemaDefModel model, string userName)
        {
            var result = _mapper.Map<SchemaDef>(model);
            await _repository.AddAsync(result, userName);
            model.IdSchemaDef = result.IdSchemaDef;
            return model;
        }

        public async Task<List<SchemaDefModel>> ReadSchemaDef()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaDefModel>>(data);

            return result;
        }

        public async Task UpdateSchemaDef(SchemaDefModel model, string userName)
        {
            var result = _mapper.Map<SchemaDef>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteSchemaDef(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<SchemaDefModel> ReadSchemaDef(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SchemaDefModel>(model);
            return result;
        }

        #endregion
    }
}