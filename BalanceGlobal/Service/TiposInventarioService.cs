
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITiposInventarioService
    {
        Task<TiposInventarioModel> CreateTiposInventario(TiposInventarioModel TiposInventarioModel, string userName);
        Task<List<TiposInventarioModel>> ReadTiposInventario();
        Task UpdateTiposInventario(TiposInventarioModel TiposInventarioModel, string userName);
        Task DeleteTiposInventario(int id, string userName);
        Task<TiposInventarioModel> ReadTiposInventario(int id);
    }
    public class TiposInventarioService : ITiposInventarioService
    {
        private readonly ITiposInventarioRepository _repository;
        private readonly IMapper _mapper;

        public TiposInventarioService(ITiposInventarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<TiposInventarioModel> CreateTiposInventario(TiposInventarioModel model, string userName)
        {
            var result = _mapper.Map<TiposInventario>(model);
            await _repository.AddAsync(result, userName);
            model.IdTiposInventario = result.IdTiposInventario;
            return model;
        }

        public async Task<List<TiposInventarioModel>> ReadTiposInventario()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TiposInventarioModel>>(data);

            return result;
        }

        public async Task UpdateTiposInventario(TiposInventarioModel model, string userName)
        {
            var result = _mapper.Map<TiposInventario>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteTiposInventario(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<TiposInventarioModel> ReadTiposInventario(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TiposInventarioModel>(model);
            return result;
        }

        #endregion
    }
}