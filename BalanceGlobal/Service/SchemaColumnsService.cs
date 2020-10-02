
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
        Task<SchemaColumnsModel> CreateSchemaColumns(SchemaColumnsModel SchemaColumnsModel, string userName);
        Task<List<SchemaColumnsModel>> ReadSchemaColumns();
        Task UpdateSchemaColumns(SchemaColumnsModel SchemaColumnsModel, string userName);
        Task DeleteSchemaColumns(int id, string userName);
        Task<SchemaColumnsModel> ReadSchemaColumns(int id);
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

        public async Task<SchemaColumnsModel> CreateSchemaColumns(SchemaColumnsModel model, string userName)
        {
            var result = _mapper.Map<SchemaColumns>(model);
            await _repository.AddAsync(result, userName);
            model.IdSchemaColumns = result.IdSchemaColumns;
            return model;
        }

        public async Task<List<SchemaColumnsModel>> ReadSchemaColumns()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SchemaColumnsModel>>(data);

            return result;
        }

        public async Task UpdateSchemaColumns(SchemaColumnsModel model, string userName)
        {
            var result = _mapper.Map<SchemaColumns>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteSchemaColumns(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<SchemaColumnsModel> ReadSchemaColumns(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SchemaColumnsModel>(model);
            return result;
        }

        #endregion
    }
}