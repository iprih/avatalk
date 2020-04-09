using Gama.RedeSocial.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Test
{
    public abstract class BaseTest
    {
        public BaseTest()
        {
            RegisterMappers.Register();
        }

        public abstract void IntegratedTest();
    }
}