
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ISistemasService
    {
        Task<SistemasModel> CreateSistemas(SistemasModel SistemasModel, string userName);
        Task<List<SistemasModel>> ReadSistemas();
        Task UpdateSistemas(SistemasModel SistemasModel, string userName);
        Task DeleteSistemas(string id, string userName);
        Task<SistemasModel> ReadSistemas(string id);
    }
    public class SistemasService : ISistemasService
    {
        private readonly ISistemasRepository _repository;
        private readonly IMapper _mapper;

        public SistemasService(ISistemasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<SistemasModel> CreateSistemas(SistemasModel model, string userName)
        {
            var result = _mapper.Map<Sistemas>(model);
            await _repository.AddAsync(result, userName);
            model.IdSistemas = result.IdSistemas;
            return model;
        }

        public async Task<List<SistemasModel>> ReadSistemas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<SistemasModel>>(data);

            return result;
        }

        public async Task UpdateSistemas(SistemasModel model, string userName)
        {
            var result = _mapper.Map<Sistemas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteSistemas(string id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<SistemasModel> ReadSistemas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<SistemasModel>(model);
            return result;
        }

        #endregion
    }
}