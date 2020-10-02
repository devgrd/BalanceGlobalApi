
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IInfraestruturasReinyeccionService
    {
        Task<InfraestruturasReinyeccionModel> CreateInfraestruturasReinyeccion(InfraestruturasReinyeccionModel InfraestruturasReinyeccionModel, string userName);
        Task<List<InfraestruturasReinyeccionModel>> ReadInfraestruturasReinyeccion();
        Task UpdateInfraestruturasReinyeccion(InfraestruturasReinyeccionModel InfraestruturasReinyeccionModel, string userName);
        Task DeleteInfraestruturasReinyeccion(int id, string userName);
        Task<InfraestruturasReinyeccionModel> ReadInfraestruturasReinyeccion(int id);
    }
    public class InfraestruturasReinyeccionService : IInfraestruturasReinyeccionService
    {
        private readonly IInfraestruturasReinyeccionRepository _repository;
        private readonly IMapper _mapper;

        public InfraestruturasReinyeccionService(IInfraestruturasReinyeccionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<InfraestruturasReinyeccionModel> CreateInfraestruturasReinyeccion(InfraestruturasReinyeccionModel model, string userName)
        {
            var result = _mapper.Map<InfraestruturasReinyeccion>(model);
            await _repository.AddAsync(result, userName);
            model.IdInfraestructurasReinyeccion = result.IdInfraestructurasReinyeccion;
            return model;
        }

        public async Task<List<InfraestruturasReinyeccionModel>> ReadInfraestruturasReinyeccion()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<InfraestruturasReinyeccionModel>>(data);

            return result;
        }

        public async Task UpdateInfraestruturasReinyeccion(InfraestruturasReinyeccionModel model, string userName)
        {
            var result = _mapper.Map<InfraestruturasReinyeccion>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteInfraestruturasReinyeccion(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<InfraestruturasReinyeccionModel> ReadInfraestruturasReinyeccion(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<InfraestruturasReinyeccionModel>(model);
            return result;
        }

        #endregion
    }
}