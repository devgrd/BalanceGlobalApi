
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISistemasSubSistemasService
    {
        Task<SistemasSubSistemasModel> CreateSistemasSubSistemas(SistemasSubSistemasModel SistemasSubSistemasModel);
        Task<List<SistemasSubSistemasModel>> ReadSistemasSubSistemas();
        Task UpdateSistemasSubSistemas(SistemasSubSistemasModel SistemasSubSistemasModel);
        Task DeleteSistemasSubSistemas(string id);
        Task<SistemasSubSistemasModel> ReadSistemasSubSistemas(string id);
    }
    public class SistemasSubSistemasService : ISistemasSubSistemasService
    {
        private readonly ISistemasSubSistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasSubSistemasService(ISistemasSubSistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SistemasSubSistemasModel> CreateSistemasSubSistemas(SistemasSubSistemasModel model)
        {
            var result = _mapper.Map<SistemasSubSistemas>(model);
            await _repository.AddAsync(result);
            model.IdSistemasSubSistemas = result.IdSistemasSubSistemas;
            return model;
        }

        public async Task<List<SistemasSubSistemasModel>> ReadSistemasSubSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SistemasSubSistemasModel>>(data);

            return result;
        }

        public async Task UpdateSistemasSubSistemas(SistemasSubSistemasModel model)
        {
            var result = _mapper.Map<SistemasSubSistemas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteSistemasSubSistemas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<SistemasSubSistemasModel> ReadSistemasSubSistemas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SistemasSubSistemasModel>(model);
            return result;
        }

        #endregion
    }
}