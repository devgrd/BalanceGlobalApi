
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
        Task<OrigenesDatosModel> CreateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel);
        Task<List<OrigenesDatosModel>> ReadOrigenesDatos();
        Task UpdateOrigenesDatos(OrigenesDatosModel OrigenesDatosModel);
        Task DeleteOrigenesDatos(string id);
        Task<OrigenesDatosModel> ReadOrigenesDatos(string id);
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

        public async Task<OrigenesDatosModel> CreateOrigenesDatos(OrigenesDatosModel model)
        {
            var result = _mapper.Map<OrigenesDatos>(model);
            await _repository.AddAsync(result);
            model.IdOrigenesDatos = result.IdOrigenesDatos;
            return model;
        }

        public async Task<List<OrigenesDatosModel>> ReadOrigenesDatos()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<OrigenesDatosModel>>(data);

            return result;
        }

        public async Task UpdateOrigenesDatos(OrigenesDatosModel model)
        {
            var result = _mapper.Map<OrigenesDatos>(model);
            await _repository.UpdateAsync(result);
        }

        public async Task DeleteOrigenesDatos(string id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task<OrigenesDatosModel> ReadOrigenesDatos(string id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<OrigenesDatosModel>(model);
            return result;
        }

        #endregion
    }
}