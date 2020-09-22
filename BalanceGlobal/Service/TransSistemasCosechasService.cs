using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITransSistemasCosechasService
    {
        Task CreateTransSistemasCosechas(TransSistemasCosechasEntity TransSistemasCosechasEntity);
        Task<List<TransSistemasCosechasEntity>> ReadTransSistemasCosechas();
        Task UpdateTransSistemasCosechas(TransSistemasCosechasEntity TransSistemasCosechasEntity);
        Task DeleteTransSistemasCosechas(string id);
        Task<TransSistemasCosechasEntity> ReadTransSistemasCosechas(string id);
    }
    public class TransSistemasCosechasService : ITransSistemasCosechasService
    {
        private readonly ITransSistemasCosechasRepository _repository;
        private readonly IMapper _mapper;

        public TransSistemasCosechasService(ITransSistemasCosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateTransSistemasCosechas(TransSistemasCosechasEntity entity)
        {
            var result = _mapper.Map<TransSistemasCosechas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<TransSistemasCosechasEntity>> ReadTransSistemasCosechas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TransSistemasCosechasEntity>>(data);

            return result;
        }

        public async Task UpdateTransSistemasCosechas(TransSistemasCosechasEntity entity)
        {
            var result = _mapper.Map<TransSistemasCosechas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteTransSistemasCosechas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<TransSistemasCosechasEntity> ReadTransSistemasCosechas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<TransSistemasCosechasEntity>(entity);
            return result;
        }

        #endregion
    }
}