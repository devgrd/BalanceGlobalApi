using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISistemasService
    {
        Task CreateSistemas(SistemasEntity SistemasEntity);
        Task<List<SistemasEntity>> ReadSistemas();
        Task UpdateSistemas(SistemasEntity SistemasEntity);
        Task DeleteSistemas(string id);
        Task<SistemasEntity> ReadSistemas(string id);
    }
    public class SistemasService : ISistemasService
    {
        private readonly ISistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasService(ISistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSistemas(SistemasEntity entity)
        {
            var result = _mapper.Map<Sistemas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SistemasEntity>> ReadSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SistemasEntity>>(data);

            return result;
        }

        public async Task UpdateSistemas(SistemasEntity entity)
        {
            var result = _mapper.Map<Sistemas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SistemasEntity> ReadSistemas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SistemasEntity>(entity);
            return result;
        }

        #endregion
    }
}