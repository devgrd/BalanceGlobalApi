
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportacionesService
    {
        Task<ImportacionesModel> CreateImportaciones(ImportacionesModel ImportacionesModel, string userName);
        Task<List<ImportacionesModel>> ReadImportaciones();
        Task UpdateImportaciones(ImportacionesModel ImportacionesModel, string userName);
        Task DeleteImportaciones(int id, string userName);
        Task<ImportacionesModel> ReadImportaciones(int id);
    }
    public class ImportacionesService : IImportacionesService
    {
        private readonly IImportacionesRepository _repository;
        private readonly IMapper _mapper;

        public ImportacionesService(IImportacionesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImportacionesModel> CreateImportaciones(ImportacionesModel model, string userName)
        {
            var result = _mapper.Map<Importaciones>(model);
            await _repository.AddAsync(result, userName);
            model.IdImportaciones = result.IdImportaciones;
            return model;
        }

        public async Task<List<ImportacionesModel>> ReadImportaciones()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportacionesModel>>(data);

            return result;
        }

        public async Task UpdateImportaciones(ImportacionesModel model, string userName)
        {
            var result = _mapper.Map<Importaciones>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImportaciones(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImportacionesModel> ReadImportaciones(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImportacionesModel>(model);
            return result;
        }

        #endregion
    }
}