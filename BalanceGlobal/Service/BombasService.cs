
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IBombasService
    {
        Task<BombasModel> CreateBombas(BombasModel BombasModel);
        Task<List<BombasModel>> ReadBombas();
        Task UpdateBombas(BombasModel BombasModel);
        Task DeleteBombas(string id);
        Task<BombasModel> ReadBombas(string id);
    }
    public class BombasService : IBombasService
    {
        private readonly IBombasRepository _repository;
        private readonly IMapper _mapper;

        public BombasService(IBombasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<BombasModel> CreateBombas(BombasModel model)
        {
            var result = _mapper.Map<Bombas>(model);
            await _repository.AddAsync(result);
            model.IdBombas = result.IdBombas;
            return model;
        }

        public async Task<List<BombasModel>> ReadBombas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<BombasModel>>(data);

            return result;
        }

        public async Task UpdateBombas(BombasModel model)
        {
            var result = _mapper.Map<Bombas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteBombas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<BombasModel> ReadBombas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<BombasModel>(model);
            return result;
        }

        #endregion
    }
}