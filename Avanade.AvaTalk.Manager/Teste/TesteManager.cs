using Avanade.AvaTalk.Entity;
using Avanade.AvaTalk.Manager.Teste;
using Avanade.AvaTalk.Repository;
using System.Collections.Generic;

namespace Avanade.AvaTalk.Manager
{
    public class TesteManager : ITesteManager
    {
        private readonly ITesteRepository _testeRepository;

        public TesteManager(ITesteRepository testeRepository)
        {
            _testeRepository = testeRepository;
        }

        public IEnumerable<TesteEntity> GetList()
        {
            return _testeRepository.GetList();
        }
    }
}
