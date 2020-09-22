using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IPorteosService
    {
        Task<List<PorteosEntity>> ReadPorteos();
        Task<PorteosEntity> ReadPorteos(string id);
    }
    public class PorteosService : IPorteosService
    {
        private readonly IPorteosRepository _repository;
        private readonly IMapper _mapper;

        public PorteosService(IPorteosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<List<PorteosEntity>> ReadPorteos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<PorteosEntity>>(data);

            return result;
        }

        public async Task<PorteosEntity> ReadPorteos(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<PorteosEntity>(entity);
            return result;
        }

        #endregion
    }
}