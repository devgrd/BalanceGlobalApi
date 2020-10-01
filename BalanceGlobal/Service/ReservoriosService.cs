
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IReservoriosService
    {
        Task<ReservoriosModel> CreateReservorios(ReservoriosModel ReservoriosModel);
        Task<List<ReservoriosModel>> ReadReservorios();
        Task UpdateReservorios(ReservoriosModel ReservoriosModel);
        Task DeleteReservorios(string id);
        Task<ReservoriosModel> ReadReservorios(string id);
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

        public async Task<ReservoriosModel> CreateReservorios(ReservoriosModel model)
        {
            var result = _mapper.Map<Reservorios>(model);
            await _repository.AddAsync(result);
            model.IdReservorios = result.IdReservorios;
            return model;
        }

        public async Task<List<ReservoriosModel>> ReadReservorios()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ReservoriosModel>>(data);

            return result;
        }

        public async Task UpdateReservorios(ReservoriosModel model)
        {
            var result = _mapper.Map<Reservorios>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteReservorios(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ReservoriosModel> ReadReservorios(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ReservoriosModel>(model);
            return result;
        }

        #endregion
    }
}