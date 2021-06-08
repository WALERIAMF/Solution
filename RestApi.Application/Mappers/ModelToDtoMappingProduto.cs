using AutoMapper;
using RestApi.Application.Dtos;
using RestApi.Domain.Entities;

namespace RestApi.Application.Mappers
{
    public class ModelToDtoMappingProduto : Profile

    {
        public ModelToDtoMappingProduto()
        {
            ProdutoDtoMap();
        }
        private void ProdutoDtoMap()
        {
            CreateMap<Produto, ProdutoDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(x => x.Nome))
                .ForMember(dest => dest.Valor, opt => opt.MapFrom(x => x.Valor));
        }
    }
}
