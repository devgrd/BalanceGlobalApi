
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ICorrienteLi2Co3Service
    {
        Task<CorrienteLi2Co3Model> CreateCorrienteLi2Co3(CorrienteLi2Co3Model CorrienteLi2Co3Model, string userName);
        Task<List<CorrienteLi2Co3Model>> ReadCorrienteLi2Co3();
        Task UpdateCorrienteLi2Co3(CorrienteLi2Co3Model CorrienteLi2Co3Model, string userName);
        Task DeleteCorrienteLi2Co3(int id, string userName);
        Task<CorrienteLi2Co3Model> ReadCorrienteLi2Co3(int id);
    }
    public class CorrienteLi2Co3Service : ICorrienteLi2Co3Service
    {
        private readonly ICorrienteLi2Co3Repository _repository;
        private readonly IMapper _mapper;

        public CorrienteLi2Co3Service(ICorrienteLi2Co3Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<CorrienteLi2Co3Model> CreateCorrienteLi2Co3(CorrienteLi2Co3Model model, string userName)
        {
            var result = _mapper.Map<CorrienteLi2Co3>(model);
            await _repository.AddAsync(result, userName);
            model.IdCorrienteLi2Co3 = result.IdCorrienteLi2Co3;
            return model;
        }

        public async Task<List<CorrienteLi2Co3Model>> ReadCorrienteLi2Co3()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<CorrienteLi2Co3Model>>(data);

            return result;
        }

        public async Task UpdateCorrienteLi2Co3(CorrienteLi2Co3Model model, string userName)
        {
            var result = _mapper.Map<CorrienteLi2Co3>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteCorrienteLi2Co3(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<CorrienteLi2Co3Model> ReadCorrienteLi2Co3(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<CorrienteLi2Co3Model>(model);
            return result;
        }

        #endregion
    }
}