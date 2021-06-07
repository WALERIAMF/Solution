using RestApi.Application.Dtos;
using RestApi.Domain.Entities;
using System.Collections.Generic;

namespace RestApi.Application.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);
        ClientDto MapperEntityToDto(Client client);

    }
}
