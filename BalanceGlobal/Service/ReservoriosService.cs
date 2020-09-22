using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IReservoriosService
    {
        Task CreateReservorios(ReservoriosEntity ReservoriosEntity);
        Task<List<ReservoriosEntity>> ReadReservorios();
        Task UpdateReservorios(ReservoriosEntity ReservoriosEntity);
        Task DeleteReservorios(string id);
        Task<ReservoriosEntity> ReadReservorios(string id);
    }
    public class ReservoriosService : IReservoriosService
    {
        private readonly IReservoriosRepository _repository;
        private readonly IMapper _mapper;

        public ReservoriosService(IReservoriosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateReservorios(ReservoriosEntity entity)
        {
            var result = _mapper.Map<Reservorios>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<ReservoriosEntity>> ReadReservorios()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ReservoriosEntity>>(data);

            return result;
        }

        public async Task UpdateReservorios(ReservoriosEntity entity)
        {
            var result = _mapper.Map<Reservorios>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteReservorios(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ReservoriosEntity> ReadReservorios(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<ReservoriosEntity>(entity);
            return result;
        }

        #endregion
    }
}