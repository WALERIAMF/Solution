using RestApi.Application.Dtos;
using RestApi.Application.Interfaces.Mappers;
using RestApi.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Application.Map
{
    public class MapperClient : IMapperClient
    {
        IEnumerable<ClientDto> clientDtos = new List<ClientDto>();

        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var cliente = new Client()
            {
                Id = clientDto.Id,
                Nome = clientDto.Nome,
                Sobrenome = clientDto.Sobrenome,
                Email = clientDto.Email
            };
           return cliente;
        }

        public ClientDto MapperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id,
                Email = client.Email,
                Nome = client.Nome,
                Sobrenome = client.Sobrenome
            };
            return clientDto;
        }

        public IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto {
                                                            Id = c.Id,
                                                            Nome = c.Nome,
                                                            Sobrenome = c.Sobrenome,
                                                            Email = c.Email
                                                        });
            return dto;
        }
    }
}

