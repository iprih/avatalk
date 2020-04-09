using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Services;
using Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [TestClass]
    public class UserTest
    {
        private readonly IUserService _service;

        public UserTest()
        {
            var repository = new UserRepository();

            _service = new UserService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameNull()
        {
            var user = new User();

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailNull()
        {
            var user = new User() 
            {
                Name = "Ana"
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmailInvalid()
        {
            var user = new User()
            {
                Name = "Ana",
                Email = "teste"
            };

            _service.Insert(user);
        }
    }
}
