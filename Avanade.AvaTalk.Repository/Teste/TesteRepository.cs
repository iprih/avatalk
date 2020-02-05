using Avanade.AvaTalk.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.AvaTalk.Repository.Teste
{
    public class TesteRepository : ITesteRepository
    {
        public IEnumerable<TesteEntity> GetList()
        {
            // aqui seria a regra para recuperar dados do banco
            // porem estamos usando dados mocados para exemplo
            // retornará uma lista com 2 elementos
            var list = new List<TesteEntity>();

            var item1 = new TesteEntity
            {
                Id = 1,
                Name = "Isabelly",
                CreationDate = DateTime.Now
            };

            var item2 = new TesteEntity
            {
                Id = 2,
                Name = "Theodoro",
                CreationDate = DateTime.Now
            };

            list.Add(item1);
            list.Add(item2);

            return list;
        }
    }
}
