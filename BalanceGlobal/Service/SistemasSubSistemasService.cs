using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISistemasSubSistemasService
    {
        Task CreateSistemasSubSistemas(SistemasSubSistemasEntity SistemasSubSistemasEntity);
        Task<List<SistemasSubSistemasEntity>> ReadSistemasSubSistemas();
        Task UpdateSistemasSubSistemas(SistemasSubSistemasEntity SistemasSubSistemasEntity);
        Task DeleteSistemasSubSistemas(string id);
        Task<SistemasSubSistemasEntity> ReadSistemasSubSistemas(string id);
    }
    public class SistemasSubSistemasService : ISistemasSubSistemasService
    {
        private readonly ISistemasSubSistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasSubSistemasService(ISistemasSubSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSistemasSubSistemas(SistemasSubSistemasEntity entity)
        {
            var result = _mapper.Map<SistemasSubSistemas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SistemasSubSistemasEntity>> ReadSistemasSubSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SistemasSubSistemasEntity>>(data);

            return result;
        }

        public async Task UpdateSistemasSubSistemas(SistemasSubSistemasEntity entity)
        {
            var result = _mapper.Map<SistemasSubSistemas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSistemasSubSistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SistemasSubSistemasEntity> ReadSistemasSubSistemas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SistemasSubSistemasEntity>(entity);
            return result;
        }

        #endregion
    }
}