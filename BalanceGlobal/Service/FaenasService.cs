using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFaenasService
    {
        Task CreateFaenas(FaenasEntity FaenasEntity);
        Task<List<FaenasEntity>> ReadFaenas();
        Task UpdateFaenas(FaenasEntity FaenasEntity);
        Task DeleteFaenas(string id);
        Task<FaenasEntity> ReadFaenas(string id);
    }
    public class FaenasService : IFaenasService
    {
        private readonly IFaenasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasService(IFaenasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateFaenas(FaenasEntity entity)
        {
            var result = _mapper.Map<Faenas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<FaenasEntity>> ReadFaenas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasEntity>>(data);

            return result;
        }

        public async Task UpdateFaenas(FaenasEntity entity)
        {
            var result = _mapper.Map<Faenas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteFaenas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<FaenasEntity> ReadFaenas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<FaenasEntity>(entity);
            return result;
        }

        #endregion
    }
}