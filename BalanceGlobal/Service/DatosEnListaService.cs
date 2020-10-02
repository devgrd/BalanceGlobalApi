
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IDatosEnListaService
    {
        Task<DatosEnListaModel> CreateDatosEnLista(DatosEnListaModel DatosEnListaModel, string userName);
        Task<List<DatosEnListaModel>> ReadDatosEnLista();
        Task UpdateDatosEnLista(DatosEnListaModel DatosEnListaModel, string userName);
        Task DeleteDatosEnLista(int id, string userName);
        Task<DatosEnListaModel> ReadDatosEnLista(int id);
    }
    public class DatosEnListaService : IDatosEnListaService
    {
        private readonly IDatosEnListaRepository _repository;
        private readonly IMapper _mapper;

        public DatosEnListaService(IDatosEnListaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<DatosEnListaModel> CreateDatosEnLista(DatosEnListaModel model, string userName)
        {
            var result = _mapper.Map<DatosEnLista>(model);
            await _repository.AddAsync(result, userName);
            model.IdDatosEnLista = result.IdDatosEnLista;
            return model;
        }

        public async Task<List<DatosEnListaModel>> ReadDatosEnLista()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<DatosEnListaModel>>(data);

            return result;
        }

        public async Task UpdateDatosEnLista(DatosEnListaModel model, string userName)
        {
            var result = _mapper.Map<DatosEnLista>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteDatosEnLista(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);
        }

        public async Task<DatosEnListaModel> ReadDatosEnLista(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<DatosEnListaModel>(model);
            return result;
        }

        #endregion
    }
}