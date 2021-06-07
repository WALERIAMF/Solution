using RestApi.Domain.Core.Interfaces.Repositories;
using RestApi.Domain.Core.Interfaces.Services;
using RestApi.Domain.Entities;

namespace RestApi.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;
        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }

    }
}
