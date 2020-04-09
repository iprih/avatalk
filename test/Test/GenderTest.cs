using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gama.RedeSocial.Test
{
    [TestClass]
    public class GenderTest : BaseTest
    {
        private readonly IGenderService _service;

        public GenderTest()
        {
            var repository = new GenderRepository();

            _service = new GenderService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTest()
        {
            var gender = new Gender();

            _service.Insert(gender);

            //nada mais executa depois de um estouro de exceção 
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var id = _service.Insert(new Gender() { Description = "TESTE" });

            _service.Delete(id);
        }

    }
}
