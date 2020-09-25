
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
        Task<ImportacionesUserParValuesModel> CreateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel);
        Task<List<ImportacionesUserParValuesModel>> ReadImportacionesUserParValues();
        Task UpdateImportacionesUserParValues(ImportacionesUserParValuesModel ImportacionesUserParValuesModel);
        Task DeleteImportacionesUserParValues(string id);
        Task<ImportacionesUserParValuesModel> ReadImportacionesUserParValues(string id);
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

        public async Task<ImportacionesUserParValuesModel> CreateImportacionesUserParValues(ImportacionesUserParValuesModel model)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(model);
            await _repository.AddAsync(result);
            model.IdImportacionesUserParValues = result.IdImportacionesUserParValues;
            return model;
        }

        public async Task<List<ImportacionesUserParValuesModel>> ReadImportacionesUserParValues()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportacionesUserParValuesModel>>(data);

            return result;
        }

        public async Task UpdateImportacionesUserParValues(ImportacionesUserParValuesModel model)
        {
            var result = _mapper.Map<ImportacionesUserParValues>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportacionesUserParValues(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportacionesUserParValuesModel> ReadImportacionesUserParValues(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportacionesUserParValuesModel>(model);
            return result;
        }

        #endregion
    }
}