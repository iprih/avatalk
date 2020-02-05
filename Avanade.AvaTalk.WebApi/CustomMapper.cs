using AutoMapper;
using Avanade.AvaTalk.Entity;

namespace Avanade.AvaTalk.WebApi
{
    public class CustomMapper : Profile
    {
        public CustomMapper()
        {
            CreateMap<TesteModel, TesteEntity>().ReverseMap();
        }
    }
}
