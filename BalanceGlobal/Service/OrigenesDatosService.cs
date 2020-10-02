
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IOrigenesDatosService
    {
        Task<OrigenesDatosModel> CreateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel, string userName);
        Task<List<OrigenesDatosModel>> ReadOrigenesDatos();
        Task UpdateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel, string userName);
        Task DeleteOrigenesDatos(int id, string userName);
        Task<OrigenesDatosModel> ReadOrigenesDatos(int id);
    }
    public class OrigenesDatosService : IOrigenesDatosService
    {
        private readonly IOrigenesDatosRepository _repository;
        private readonly IMapper _mapper;

        public OrigenesDatosService(IOrigenesDatosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<OrigenesDatosModel> CreateOrigenesDatos(OrigenesDatosModel model, string userName)
        {
            var result = _mapper.Map<OrigenesDatos>(model);
            await _repository.AddAsync(result, userName);
            model.IdOrigenesDatos = result.IdOrigenesDatos;
            return model;
        }

        public async Task<List<OrigenesDatosModel>> ReadOrigenesDatos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OrigenesDatosModel>>(data);

            return result;
        }

        public async Task UpdateOrigenesDatos(OrigenesDatosModel model, string userName)
        {
            var result = _mapper.Map<OrigenesDatos>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteOrigenesDatos(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<OrigenesDatosModel> ReadOrigenesDatos(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<OrigenesDatosModel>(model);
            return result;
        }

        #endregion
    }
}