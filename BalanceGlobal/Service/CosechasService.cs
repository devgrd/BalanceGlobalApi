using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICosechasService
    {
        Task<List<CosechasEntity>> ReadCosechas();
        Task<CosechasEntity> ReadCosechas(string id);
    }
    public class CosechasService : ICosechasService
    {
        private readonly ICosechasRepository _repository;
        private readonly IMapper _mapper;

        public CosechasService(ICosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<List<CosechasEntity>> ReadCosechas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CosechasEntity>>(data);

            return result;
        }

        public async Task<CosechasEntity> ReadCosechas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<CosechasEntity>(entity);
            return result;
        }

        #endregion
    }
}