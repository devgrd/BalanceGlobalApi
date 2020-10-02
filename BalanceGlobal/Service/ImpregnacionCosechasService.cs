
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImpregnacionCosechasService
    {
        Task<ImpregnacionCosechasModel> CreateImpregnacionCosechas(ImpregnacionCosechasModel ImpregnacionCosechasModel, string userName);
        Task<List<ImpregnacionCosechasModel>> ReadImpregnacionCosechas();
        Task UpdateImpregnacionCosechas(ImpregnacionCosechasModel ImpregnacionCosechasModel, string userName);
        Task DeleteImpregnacionCosechas(int id, string userName);
        Task<ImpregnacionCosechasModel> ReadImpregnacionCosechas(int id);
    }
    public class ImpregnacionCosechasService : IImpregnacionCosechasService
    {
        private readonly IImpregnacionCosechasRepository _repository;
        private readonly IMapper _mapper;

        public ImpregnacionCosechasService(IImpregnacionCosechasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImpregnacionCosechasModel> CreateImpregnacionCosechas(ImpregnacionCosechasModel model, string userName)
        {
            var result = _mapper.Map<ImpregnacionCosechas>(model);
            await _repository.AddAsync(result, userName);
            model.IdImpregnacionCosechas = result.IdImpregnacionCosechas;
            return model;
        }

        public async Task<List<ImpregnacionCosechasModel>> ReadImpregnacionCosechas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImpregnacionCosechasModel>>(data);

            return result;
        }

        public async Task UpdateImpregnacionCosechas(ImpregnacionCosechasModel model, string userName)
        {
            var result = _mapper.Map<ImpregnacionCosechas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImpregnacionCosechas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImpregnacionCosechasModel> ReadImpregnacionCosechas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImpregnacionCosechasModel>(model);
            return result;
        }

        #endregion
    }
}