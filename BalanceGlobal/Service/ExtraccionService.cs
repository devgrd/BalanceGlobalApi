
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IExtraccionService
    {
        Task<ExtraccionModel> CreateExtraccion(ExtraccionModel ExtraccionModel);
        Task<List<ExtraccionModel>> ReadExtraccion();
        Task UpdateExtraccion(ExtraccionModel ExtraccionModel);
        Task DeleteExtraccion(string id);
        Task<ExtraccionModel> ReadExtraccion(string id);
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

        public async Task<ExtraccionModel> CreateExtraccion(ExtraccionModel model)
        {
            var result = _mapper.Map<Extraccion>(model);
            await _repository.AddAsync(result);
            model.IdExtraccion = result.IdExtraccion;
            return model;
        }

        public async Task<List<ExtraccionModel>> ReadExtraccion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ExtraccionModel>>(data);

            return result;
        }

        public async Task UpdateExtraccion(ExtraccionModel model)
        {
            var result = _mapper.Map<Extraccion>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteExtraccion(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<ExtraccionModel> ReadExtraccion(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ExtraccionModel>(model);
            return result;
        }

        #endregion
    }
}