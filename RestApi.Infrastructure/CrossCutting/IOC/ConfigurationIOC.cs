using Autofac;
using AutoMapper;
using RestApi.Application;
using RestApi.Application.Interfaces;
using RestApi.Application.Interfaces.Mappers;
using RestApi.Application.Map;
using RestApi.Application.Mappers;
using RestApi.Domain.Core.Interfaces.Repositories;
using RestApi.Domain.Core.Interfaces.Services;
using RestApi.Domain.Services;
using RestApi.Infrastructure.Data.Repository;

namespace RestApi.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingClient());
            }));
            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}
