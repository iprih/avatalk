using AutoMapper;
using Avanade.AvaTalk.Manager.Teste;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Avanade.AvaTalk.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ITesteManager _testeManager;
        private readonly IMapper _mapper;

        public TesteController(ITesteManager testeManager,
                               IMapper mapper)
        {
            _testeManager = testeManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<TesteModel> GetList()
        {
            var items = _testeManager.GetList();

            var itemsModel = _mapper.Map<IEnumerable<TesteModel>>(items);

            return itemsModel;
        }
    }
}