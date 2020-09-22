using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Entities;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISubsistemasService
    {
        Task CreateSubsistemas(SubsistemasEntity SubsistemasEntity);
        Task<List<SubsistemasEntity>> ReadSubsistemas();
        Task UpdateSubsistemas(SubsistemasEntity SubsistemasEntity);
        Task DeleteSubsistemas(string id);
        Task<SubsistemasEntity> ReadSubsistemas(string id);
    }
    public class SubsistemasService : ISubsistemasService
    {
        private readonly ISubsistemasRepository _repository;
        private readonly IMapper _mapper;

        public SubsistemasService(ISubsistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task CreateSubsistemas(SubsistemasEntity entity)
        {
            var result = _mapper.Map<Subsistemas>(entity);
            await _repository.AddAsync(result);
        }

        public async Task<List<SubsistemasEntity>> ReadSubsistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SubsistemasEntity>>(data);

            return result;
        }

        public async Task UpdateSubsistemas(SubsistemasEntity entity)
        {
            var result = _mapper.Map<Subsistemas>(entity);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSubsistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SubsistemasEntity> ReadSubsistemas(string id)
        {
            var entity = await _repository.GetById(id);
            var result = _mapper.Map<SubsistemasEntity>(entity);
            return result;
        }

        #endregion
    }
}