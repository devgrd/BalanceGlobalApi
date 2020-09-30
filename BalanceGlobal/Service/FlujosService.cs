
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFlujosService
    {
        Task<FlujosModel> CreateFlujos(FlujosModel FlujosModel, string userName);
        Task<List<FlujosModel>> ReadFlujos();
        Task UpdateFlujos(FlujosModel FlujosModel, string userName);
        Task DeleteFlujos(string id, string userName);
        Task<FlujosModel> ReadFlujos(string id);
    }
    public class FlujosService : IFlujosService
    {
        private readonly IFlujosRepository _repository;
        private readonly IMapper _mapper;

        public FlujosService(IFlujosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<FlujosModel> CreateFlujos(FlujosModel model, string userName)
        {
            var result = _mapper.Map<Flujos>(model);
            await _repository.AddAsync(result, userName);
            model.IdFlujos = result.IdFlujos;
            return model;
        }

        public async Task<List<FlujosModel>> ReadFlujos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FlujosModel>>(data);

            return result;
        }

        public async Task UpdateFlujos(FlujosModel model, string userName)
        {
            var result = _mapper.Map<Flujos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteFlujos(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<FlujosModel> ReadFlujos(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FlujosModel>(model);
            return result;
        }

        #endregion
    }
}