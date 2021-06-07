using AutoMapper;
using RestApi.Application.Dtos;
using RestApi.Domain.Entities;

namespace RestApi.Application.Mappers
{
    public class DtoToModelMappingClient : Profile
    {
        public DtoToModelMappingClient()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<ClientDto, Client>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(x => x.Sobrenome))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.DataCadastro, opt => opt.Ignore())
                .ForMember(dest => dest.IsActive, opt => opt.Ignore());

        }
    }
}
