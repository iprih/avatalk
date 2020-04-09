using Gama.RedeSocial.Domain.Entities;
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
    public class MidiaTypeTest : BaseTest
    {
        private readonly IMidiaTypeService _service;

        public MidiaTypeTest()
        {
            var repository = new MidiaTypeRepository();

            _service = new MidiaTypeService(repository);
        }

       
        public void ValidateTest()
        {
            var midiaType = new MidiaType();

            _service.Insert(midiaType);
        }

      
        public override void IntegratedTest()
        {
            var type = new MidiaType
            {
                Description = "TESTE",
                Extensions = "ext,para,teste"
            };

            var id = _service.Insert(type);

            _service.Delete(id);
        }
    }
}
