
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPermeabilidadService
    {
        Task<PermeabilidadModel> CreatePermeabilidad(PermeabilidadModel PermeabilidadModel, string userName);
        Task<List<PermeabilidadModel>> ReadPermeabilidad();
        Task UpdatePermeabilidad(PermeabilidadModel PermeabilidadModel, string userName);
        Task DeletePermeabilidad(int id, string userName);
        Task<PermeabilidadModel> ReadPermeabilidad(int id);
    }
    public class PermeabilidadService : IPermeabilidadService
    {
        private readonly IPermeabilidadRepository _repository;
        private readonly IMapper _mapper;

        public PermeabilidadService(IPermeabilidadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<PermeabilidadModel> CreatePermeabilidad(PermeabilidadModel model, string userName)
        {
            var result = _mapper.Map<Permeabilidad>(model);
            await _repository.AddAsync(result, userName);
            model.IdPermeabilidad = result.IdPermeabilidad;
            return model;
        }

        public async Task<List<PermeabilidadModel>> ReadPermeabilidad()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PermeabilidadModel>>(data);

            return result;
        }

        public async Task UpdatePermeabilidad(PermeabilidadModel model, string userName)
        {
            var result = _mapper.Map<Permeabilidad>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeletePermeabilidad(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<PermeabilidadModel> ReadPermeabilidad(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<PermeabilidadModel>(model);
            return result;
        }

        #endregion
    }
}