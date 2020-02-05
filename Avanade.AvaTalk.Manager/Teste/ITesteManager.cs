using Avanade.AvaTalk.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.AvaTalk.Manager.Teste
{
    public interface ITesteManager
    {
        IEnumerable<TesteEntity> GetList();
    }
}
