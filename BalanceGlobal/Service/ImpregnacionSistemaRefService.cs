
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IImpregnacionSistemaRefService
    {
        Task<ImpregnacionSistemaRefModel> CreateImpregnacionSistemaRef(ImpregnacionSistemaRefModel ImpregnacionSistemaRefModel, string userName);
        Task<List<ImpregnacionSistemaRefModel>> ReadImpregnacionSistemaRef();
        Task UpdateImpregnacionSistemaRef(ImpregnacionSistemaRefModel ImpregnacionSistemaRefModel, string userName);
        Task DeleteImpregnacionSistemaRef(int id, string userName);
        Task<ImpregnacionSistemaRefModel> ReadImpregnacionSistemaRef(int id);
    }
    public class ImpregnacionSistemaRefService : IImpregnacionSistemaRefService
    {
        private readonly IImpregnacionSistemaRefRepository _repository;
        private readonly IMapper _mapper;

        public ImpregnacionSistemaRefService(IImpregnacionSistemaRefRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<ImpregnacionSistemaRefModel> CreateImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, string userName)
        {
            var result = _mapper.Map<ImpregnacionSistemaRef>(model);
            await _repository.AddAsync(result, userName);
            model.IdImpregnacionSistemaRef = result.IdImpregnacionSistemaRef;
            return model;
        }

        public async Task<List<ImpregnacionSistemaRefModel>> ReadImpregnacionSistemaRef()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<ImpregnacionSistemaRefModel>>(data);

            return result;
        }

        public async Task UpdateImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, string userName)
        {
            var result = _mapper.Map<ImpregnacionSistemaRef>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteImpregnacionSistemaRef(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<ImpregnacionSistemaRefModel> ReadImpregnacionSistemaRef(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<ImpregnacionSistemaRefModel>(model);
            return result;
        }

        #endregion
    }
}