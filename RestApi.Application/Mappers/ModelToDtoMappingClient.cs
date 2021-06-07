using AutoMapper;
using RestApi.Application.Dtos;
using RestApi.Domain.Entities;

namespace RestApi.Application.Mappers
{
    public class ModelToDtoMappingClient : Profile

    {
        public ModelToDtoMappingClient()
        {
            ClientDtoMap();
        }
        private void ClientDtoMap()
        {
            CreateMap<Client, ClientDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(x => x.Sobrenome))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email));


        }
    }
}
