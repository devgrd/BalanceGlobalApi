using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImportacionesService
    {
        Task CreateImportaciones(ImportacionesEntity ImportacionesEntity);
        Task<List<ImportacionesEntity>> ReadImportaciones();
        Task UpdateImportaciones(ImportacionesEntity ImportacionesEntity);
        Task DeleteImportaciones(string id);
        Task<ImportacionesEntity> ReadImportaciones(string id);
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

        public async Task CreateImportaciones(ImportacionesEntity entity)
        {
            var result = _mapper.Map<Importaciones>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ImportacionesEntity>> ReadImportaciones()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImportacionesEntity>>(data);

            return result;
        }

        public async Task UpdateImportaciones(ImportacionesEntity entity)
        {
            var result = _mapper.Map<Importaciones>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteImportaciones(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ImportacionesEntity> ReadImportaciones(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ImportacionesEntity>(entity);
            return result;
        }

        #endregion
    }
}