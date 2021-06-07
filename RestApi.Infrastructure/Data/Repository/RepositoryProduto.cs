using RestApi.Domain.Core.Interfaces.Repositories;
using RestApi.Domain.Entities;

namespace RestApi.Infrastructure.Data.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;
        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
