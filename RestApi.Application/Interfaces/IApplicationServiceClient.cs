using RestApi.Application.Dtos;
using System.Collections.Generic;

namespace RestApi.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDto clientDto);
        void Update(ClientDto clientDto);
        void Remove(ClientDto clientDto);
        IEnumerable<ClientDto> GetAll();
        ClientDto GetById(int id);
    }
}
