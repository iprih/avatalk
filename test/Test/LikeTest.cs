using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Test
{
    [TestClass]
    public class LikeTest : BaseTest
    {
        private readonly ILikeService _service;

        public LikeTest()
        {
            var repository = new LikeRepository();

            _service = new LikeService(repository);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var like = new Like()
            {
                PostId = new Guid("DBC111D4-AD0F-438C-806F-E5264B71A8E1"),
                UserId = new Guid("DAAEE0A1-3E61-431F-A1AF-5BC373D6754C")
            };

            var result = _service.Insert(like);
        }
    }
}
