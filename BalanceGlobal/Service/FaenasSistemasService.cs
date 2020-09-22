using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFaenasSistemasService
    {
        Task CreateFaenasSistemas(FaenasSistemasEntity FaenasSistemasEntity);
        Task<List<FaenasSistemasEntity>> ReadFaenasSistemas();
        Task UpdateFaenasSistemas(FaenasSistemasEntity FaenasSistemasEntity);
        Task DeleteFaenasSistemas(string id);
        Task<FaenasSistemasEntity> ReadFaenasSistemas(string id);
    }
    public class FaenasSistemasService : IFaenasSistemasService
    {
        private readonly IFaenasSistemasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasSistemasService(IFaenasSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateFaenasSistemas(FaenasSistemasEntity entity)
        {
            var result = _mapper.Map<FaenasSistemas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<FaenasSistemasEntity>> ReadFaenasSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasSistemasEntity>>(data);

            return result;
        }

        public async Task UpdateFaenasSistemas(FaenasSistemasEntity entity)
        {
            var result = _mapper.Map<FaenasSistemas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteFaenasSistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<FaenasSistemasEntity> ReadFaenasSistemas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<FaenasSistemasEntity>(entity);
            return result;
        }

        #endregion
    }
}