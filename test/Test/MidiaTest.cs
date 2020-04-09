using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gama.RedeSocial.Test
{
    [TestClass]
    public class MidiaTest : BaseTest
    {
        private readonly IMidiaService _service;

        public MidiaTest()
        {
            var repository = new MidiaRepository();

            _service = new MidiaService(repository);
        }

        [TestMethod]
        public void ValidateTest()
        {
            var midiaType = new Midia();

            _service.Insert(midiaType);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var midiaTypeReposiory = new MidiaTypeRepository();

            var type = midiaTypeReposiory.Get(x => x.Description == "Photo").Single();

            var midia = new Midia
            {
                Description = "Foto na praia",
                Path = "/photos/file.jpg",
                MidiaTypeId = type.Id
            };

            var id = _service.Insert(midia);

            _service.Delete(id);
        }
    }
}
