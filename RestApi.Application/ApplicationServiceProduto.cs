using RestApi.Application.Dtos;
using RestApi.Application.Interfaces;
using RestApi.Application.Interfaces.Mappers;
using RestApi.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApi.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto,
                                        IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }
        public void Add(ProdutoDto produtoDto)
        {
            var produtos = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produtos);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutoDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}
