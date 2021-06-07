using AutoMapper;
using RestApi.Application.Dtos;
using RestApi.Application.Interfaces;
using RestApi.Application.Interfaces.Mappers;
using RestApi.Domain.Core.Interfaces.Services;
using RestApi.Domain.Entities;
using System.Collections.Generic;

namespace RestApi.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;
        private readonly IMapper mapper;

        public ApplicationServiceClient(IServiceClient serviceClient,
                                        IMapperClient mapperClient,
                                        IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
            this.mapper = mapper;
        }
        public void Add(ClientDto clientDto)
        {
            //var clients = mapperClient.MapperDtoToEntity(clientDto);
            var clients = mapper.Map<Client>(clientDto);
            serviceClient.Add(clients);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListClientDto(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MapperEntityToDto(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Update(client);
        }
    }
}
