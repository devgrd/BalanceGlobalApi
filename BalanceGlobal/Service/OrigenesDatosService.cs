using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IOrigenesDatosService
    {
        Task CreateOrigenesDatos(OrigenesDatosEntity OrigenesDatosEntity);
        Task<List<OrigenesDatosEntity>> ReadOrigenesDatos();
        Task UpdateOrigenesDatos(OrigenesDatosEntity OrigenesDatosEntity);
        Task DeleteOrigenesDatos(string id);
        Task<OrigenesDatosEntity> ReadOrigenesDatos(string id);
    }
    public class OrigenesDatosService : IOrigenesDatosService
    {
        private readonly IOrigenesDatosRepository _repository;
        private readonly IMapper _mapper;

        public OrigenesDatosService(IOrigenesDatosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateOrigenesDatos(OrigenesDatosEntity entity)
        {
            var result = _mapper.Map<OrigenesDatos>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<OrigenesDatosEntity>> ReadOrigenesDatos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OrigenesDatosEntity>>(data);

            return result;
        }

        public async Task UpdateOrigenesDatos(OrigenesDatosEntity entity)
        {
            var result = _mapper.Map<OrigenesDatos>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteOrigenesDatos(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<OrigenesDatosEntity> ReadOrigenesDatos(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<OrigenesDatosEntity>(entity);
            return result;
        }

        #endregion
    }
}