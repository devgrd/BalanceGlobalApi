
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportadoresService
    {
        Task<ImportadoresModel> CreateImportadores(ImportadoresModel ImportadoresModel);
        Task<List<ImportadoresModel>> ReadImportadores();
        Task UpdateImportadores(ImportadoresModel ImportadoresModel);
        Task DeleteImportadores(string id);
        Task<ImportadoresModel> ReadImportadores(string id);
    }
    public class ImportadoresService : IImportadoresService
    {
        private readonly IImportadoresRepository _repository;
        private readonly IMapper _mapper;

        public ImportadoresService(IImportadoresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImportadoresModel> CreateImportadores(ImportadoresModel model)
        {
            var result = _mapper.Map<Importadores>(model);
            await _repository.AddAsync(result);
            model.IdImportadores = result.IdImportadores;
            return model;
        }

        public async Task<List<ImportadoresModel>> ReadImportadores()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportadoresModel>>(data);

            return result;
        }

        public async Task UpdateImportadores(ImportadoresModel model)
        {
            var result = _mapper.Map<Importadores>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportadores(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportadoresModel> ReadImportadores(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportadoresModel>(model);
            return result;
        }

        #endregion
    }
}