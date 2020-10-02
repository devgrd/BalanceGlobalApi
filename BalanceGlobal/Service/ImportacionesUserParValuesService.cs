
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportacionesUserParValuesService
    {
        Task<ImportacionesUserParValuesModel> CreateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel, string userName);
        Task<List<ImportacionesUserParValuesModel>> ReadImportacionesUserParValues();
        Task UpdateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel, string userName);
        Task DeleteImportacionesUserParValues(int id, string userName);
        Task<ImportacionesUserParValuesModel> ReadImportacionesUserParValues(int id);
    }
    public class ImportacionesUserParValuesService : IImportacionesUserParValuesService
    {
        private readonly IImportacionesUserParValuesRepository _repository;
        private readonly IMapper _mapper;

        public ImportacionesUserParValuesService(IImportacionesUserParValuesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImportacionesUserParValuesModel> CreateImportacionesUserParValues(ImportacionesUserParValuesModel model, string userName)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(model);
            await _repository.AddAsync(result, userName);
            model.IdImportacionesUserParValues = result.IdImportacionesUserParValues;
            return model;
        }

        public async Task<List<ImportacionesUserParValuesModel>> ReadImportacionesUserParValues()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportacionesUserParValuesModel>>(data);

            return result;
        }

        public async Task UpdateImportacionesUserParValues(ImportacionesUserParValuesModel model, string userName)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImportacionesUserParValues(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImportacionesUserParValuesModel> ReadImportacionesUserParValues(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportacionesUserParValuesModel>(model);
            return result;
        }

        #endregion
    }
}