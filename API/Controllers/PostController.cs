using System;
using System.Collections.Generic;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _app;

        public PostController(IPostApplication app)
        {
            _app = app;
        }


        // GET: api/Post
        [HttpGet]
        public IEnumerable<Post> GetPost()
        {
            return _app.Get(x => x.Active);
        }

        // GET: api/Post/5
        [HttpGet("{id}", Name = "Get")]
        public Post Get(Guid id)
        {
            return _app. BuscarPostPorID(id);
        }

        // POST: api/Post
        [HttpPost]
        public Guid Post([FromBody] Post post)
        {
            return _app.Insert(post);

        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Post post)
        {
            post.Id = id;

            _app.Update(post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //_app.Delete(id);
        }
    }
}
