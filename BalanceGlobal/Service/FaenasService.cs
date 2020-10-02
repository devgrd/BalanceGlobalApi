
using AutoMapper;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Models;
using BalanceGlobal.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BalanceGlobal.Service
{

    public interface IFaenasService
    {
        Task<FaenasModel> CreateFaenas(FaenasModel FaenasModel, string userName);
        Task<List<FaenasModel>> ReadFaenas();
        Task UpdateFaenas(FaenasModel FaenasModel, string userName);
        Task DeleteFaenas(int id, string userName);
        Task<FaenasModel> ReadFaenas(int id);
    }
    public class FaenasService : IFaenasService
    {
        private readonly IFaenasRepository _repository;
        private readonly IMapper _mapper;

        public FaenasService(IFaenasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region CRUD

        public async Task<FaenasModel> CreateFaenas(FaenasModel model, string userName)
        {
            var result = _mapper.Map<Faenas>(model);
            await _repository.AddAsync(result, userName);
            model.IdFaenas = result.IdFaenas;
            return model;
        }

        public async Task<List<FaenasModel>> ReadFaenas()
        {
            var data = await _repository.GetAllAsync();
            var result = _mapper.Map<List<FaenasModel>>(data);

            return result;
        }

        public async Task UpdateFaenas(FaenasModel model, string userName)
        {
            var result = _mapper.Map<Faenas>(model);
            await _repository.UpdateAsync(result, userName);
        }

        public async Task DeleteFaenas(int id, string userName)
        {
            await _repository.RemoveAsync(id, userName);          
        }

        public async Task<FaenasModel> ReadFaenas(int id)
        {
            var model = await _repository.GetById(id);
            var result = _mapper.Map<FaenasModel>(model);
            return result;
        }

        #endregion


    }
}