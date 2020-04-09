using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gama.RedeSocial.Test
{
    [TestClass]
    public class InviteStatusTest : BaseTest
    {
        private readonly IInviteStatusService _service;

        public InviteStatusTest()
        {
            var repository = new InviteStatusRepository();

            _service = new InviteStatusService(repository);
        }


        [TestMethod]
        public override void IntegratedTest()
        {
            var id = _service.Insert(new InviteStatus() { Description = "TESTE" });

            _service.Delete(id);
        }
    }
}
