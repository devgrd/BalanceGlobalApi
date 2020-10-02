
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IReactivosService
    {
        Task<ReactivosModel> CreateReactivos(ReactivosModel ReactivosModel, string userName);
        Task<List<ReactivosModel>> ReadReactivos();
        Task UpdateReactivos(ReactivosModel ReactivosModel, string userName);
        Task DeleteReactivos(int id, string userName);
        Task<ReactivosModel> ReadReactivos(int id);
    }
    public class ReactivosService : IReactivosService
    {
        private readonly IReactivosRepository _repository;
        private readonly IMapper _mapper;

        public ReactivosService(IReactivosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ReactivosModel> CreateReactivos(ReactivosModel model, string userName)
        {
            var result = _mapper.Map<Reactivos>(model);
            await _repository.AddAsync(result, userName);
            model.IdReactivos = result.IdReactivos;
            return model;
        }

        public async Task<List<ReactivosModel>> ReadReactivos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ReactivosModel>>(data);

            return result;
        }

        public async Task UpdateReactivos(ReactivosModel model, string userName)
        {
            var result = _mapper.Map<Reactivos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteReactivos(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ReactivosModel> ReadReactivos(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ReactivosModel>(model);
            return result;
        }

        #endregion
    }
}