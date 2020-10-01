
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISchemaColumnsService
    {
        Task<SchemaColumnsModel> CreateSchemaColumns(SchemaColumnsModel SchemaColumnsModel);
        Task<List<SchemaColumnsModel>> ReadSchemaColumns();
        Task UpdateSchemaColumns(SchemaColumnsModel SchemaColumnsModel);
        Task DeleteSchemaColumns(string id);
        Task<SchemaColumnsModel> ReadSchemaColumns(string id);
    }
    public class SchemaColumnsService : ISchemaColumnsService
    {
        private readonly ISchemaColumnsRepository _repository;
        private readonly IMapper _mapper;

        public SchemaColumnsService(ISchemaColumnsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SchemaColumnsModel> CreateSchemaColumns(SchemaColumnsModel model)
        {
            var result = _mapper.Map<SchemaColumns>(model);
            await _repository.AddAsync(result);
            model.IdSchemaColumns = result.IdSchemaColumns;
            return model;
        }

        public async Task<List<SchemaColumnsModel>> ReadSchemaColumns()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsModel>>(data);

            return result;
        }

        public async Task UpdateSchemaColumns(SchemaColumnsModel model)
        {
            var result = _mapper.Map<SchemaColumns>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSchemaColumns(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SchemaColumnsModel> ReadSchemaColumns(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SchemaColumnsModel>(model);
            return result;
        }

        #endregion
    }
}