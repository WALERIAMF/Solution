using RestApi.Domain.Core.Interfaces.Repositories;
using RestApi.Domain.Entities;

namespace RestApi.Infrastructure.Data.Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;
        public RepositoryClient(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
