
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IDescargaPlataformasService
    {
        Task<DescargaPlataformasModel> CreateDescargaPlataformas(DescargaPlataformasModel DescargaPlataformasModel, string userName);
        Task<List<DescargaPlataformasModel>> ReadDescargaPlataformas();
        Task UpdateDescargaPlataformas(DescargaPlataformasModel DescargaPlataformasModel, string userName);
        Task DeleteDescargaPlataformas(int id, string userName);
        Task<DescargaPlataformasModel> ReadDescargaPlataformas(int id);
    }
    public class DescargaPlataformasService : IDescargaPlataformasService
    {
        private readonly IDescargaPlataformasRepository _repository;
        private readonly IMapper _mapper;

        public DescargaPlataformasService(IDescargaPlataformasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<DescargaPlataformasModel> CreateDescargaPlataformas(DescargaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<DescargaPlataformas>(model);
            await _repository.AddAsync(result, userName);
            model.IdDescargaPlataformas = result.IdDescargaPlataformas;
            return model;
        }

        public async Task<List<DescargaPlataformasModel>> ReadDescargaPlataformas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<DescargaPlataformasModel>>(data);

            return result;
        }

        public async Task UpdateDescargaPlataformas(DescargaPlataformasModel model, string userName)
        {
            var result = _mapper.Map<DescargaPlataformas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteDescargaPlataformas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<DescargaPlataformasModel> ReadDescargaPlataformas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<DescargaPlataformasModel>(model);
            return result;
        }

        #endregion
    }
}