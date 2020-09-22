using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IExtraccionService
    {
        Task CreateExtraccion(ExtraccionEntity ExtraccionEntity);
        Task<List<ExtraccionEntity>> ReadExtraccion();
        Task UpdateExtraccion(ExtraccionEntity ExtraccionEntity);
        Task DeleteExtraccion(string id);
        Task<ExtraccionEntity> ReadExtraccion(string id);
    }
    public class ExtraccionService : IExtraccionService
    {
        private readonly IExtraccionRepository _repository;
        private readonly IMapper _mapper;

        public ExtraccionService(IExtraccionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateExtraccion(ExtraccionEntity entity)
        {
            var result = _mapper.Map<Extraccion>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ExtraccionEntity>> ReadExtraccion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ExtraccionEntity>>(data);

            return result;
        }

        public async Task UpdateExtraccion(ExtraccionEntity entity)
        {
            var result = _mapper.Map<Extraccion>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteExtraccion(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ExtraccionEntity> ReadExtraccion(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ExtraccionEntity>(entity);
            return result;
        }

        #endregion
    }
}