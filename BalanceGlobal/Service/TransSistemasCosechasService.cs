
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface ITransSistemasCosechasService
    {
        Task<TransSistemasCosechasModel> CreateTransSistemasCosechas(TransSistemasCosechasModel TransSistemasCosechasModel);
        Task<List<TransSistemasCosechasModel>> ReadTransSistemasCosechas();
        Task UpdateTransSistemasCosechas(TransSistemasCosechasModel TransSistemasCosechasModel);
        Task DeleteTransSistemasCosechas(string id);
        Task<TransSistemasCosechasModel> ReadTransSistemasCosechas(string id);
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

        public async Task<TransSistemasCosechasModel> CreateTransSistemasCosechas(TransSistemasCosechasModel model)
        {
            var result = _mapper.Map<TransSistemasCosechas>(model);
            await _repository.AddAsync(result);
            model.IdTransSistemasCosechas = result.IdTransSistemasCosechas;
            return model;
        }

        public async Task<List<TransSistemasCosechasModel>> ReadTransSistemasCosechas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<TransSistemasCosechasModel>>(data);

            return result;
        }

        public async Task UpdateTransSistemasCosechas(TransSistemasCosechasModel model)
        {
            var result = _mapper.Map<TransSistemasCosechas>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteTransSistemasCosechas(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<TransSistemasCosechasModel> ReadTransSistemasCosechas(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<TransSistemasCosechasModel>(model);
            return result;
        }

        #endregion
    }
}