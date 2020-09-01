using BalanceGlobal.Database.Tables;
using BalanceGlobal.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BalanceGlobal.Service
{
    public interface IService 
    {
        IEnumerable<Periodos> GetPeriodos();
        IEnumerable<Sistemas> GetSistemas();
        IEnumerable<Subsistemas> GetSubSistemas();


    }
    public class Service : IService
    {
        private readonly IPeriodoRepository _periodoRepository;
        private readonly ISistemasRepository _sistemasRepository;
        private readonly ISubSistemasRepository _subSistemasRepository;

        public Service(
            IPeriodoRepository periodoReposirory,
            ISistemasRepository sistemasRepository,
            ISubSistemasRepository subSistemasRepository
            )
        {
            _periodoRepository = periodoReposirory;
            _sistemasRepository = sistemasRepository;
            _subSistemasRepository = subSistemasRepository;
        }

        public IEnumerable<Periodos> GetPeriodos()
        {
            return _periodoRepository.GetAll();
        }

        public IEnumerable<Sistemas> GetSistemas()
        {
            return _sistemasRepository.GetAll();
        }

        public IEnumerable<Subsistemas> GetSubSistemas()
        {
            return _subSistemasRepository.GetAll();
        }
    }
}
