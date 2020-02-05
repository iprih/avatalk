using Avanade.AvaTalk.Entity;
using System.Collections.Generic;

namespace Avanade.AvaTalk.Repository
{
    public interface ITesteRepository
    {
        IEnumerable<TesteEntity> GetList();
    }
}
