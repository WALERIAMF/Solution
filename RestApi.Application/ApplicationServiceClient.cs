using AutoMapper;
using RestApi.Application.Dtos;
using RestApi.Application.Interfaces;
using RestApi.Domain.Core.Interfaces.Services;
using RestApi.Domain.Entities;
using System.Collections.Generic;

namespace RestApi.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapper mapper;

        public ApplicationServiceClient(IServiceClient serviceClient,
                                        IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapper = mapper;
        }
        public void Add(ClientDto clientDto)
        {

            var clients = mapper.Map<Client>(clientDto);
            serviceClient.Add(clients);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            var clientDto = mapper.Map<IEnumerable<ClientDto>>(clients);
            return clientDto;
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            var clientDto = mapper.Map<ClientDto>(client);
            return clientDto;
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Update(client);
        }
    }
}
