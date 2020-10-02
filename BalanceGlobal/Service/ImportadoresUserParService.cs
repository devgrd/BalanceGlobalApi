
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportadoresUserParService
    {
        Task<ImportadoresUserParModel> CreateImportadoresUserPar(ImportadoresUserParModel ImportadoresUserParModel, string userName);
        Task<List<ImportadoresUserParModel>> ReadImportadoresUserPar();
        Task UpdateImportadoresUserPar(ImportadoresUserParModel ImportadoresUserParModel, string userName);
        Task DeleteImportadoresUserPar(int id, string userName);
        Task<ImportadoresUserParModel> ReadImportadoresUserPar(int id);
    }
    public class ImportadoresUserParService : IImportadoresUserParService
    {
        private readonly IImportadoresUserParRepository _repository;
        private readonly IMapper _mapper;

        public ImportadoresUserParService(IImportadoresUserParRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImportadoresUserParModel> CreateImportadoresUserPar(ImportadoresUserParModel model, string userName)
        {
            var result = _mapper.Map<ImportadoresUserPar>(model);
            await _repository.AddAsync(result, userName);
            model.IdImportadoresUserPar = result.IdImportadoresUserPar;
            return model;
        }

        public async Task<List<ImportadoresUserParModel>> ReadImportadoresUserPar()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportadoresUserParModel>>(data);

            return result;
        }

        public async Task UpdateImportadoresUserPar(ImportadoresUserParModel model, string userName)
        {
            var result = _mapper.Map<ImportadoresUserPar>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImportadoresUserPar(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImportadoresUserParModel> ReadImportadoresUserPar(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportadoresUserParModel>(model);
            return result;
        }

        #endregion
    }
}