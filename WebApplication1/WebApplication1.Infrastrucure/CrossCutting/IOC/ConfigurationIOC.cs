using Autofac;
using WebApplication1.Application;
using WebApplication1.Application.Interfaces;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Application.Mappers;
using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Core.Interfaces.Services;
using WebApplication1.Domain.Services;
using WebApplication1.Infrastrucure.Data.Repositories;

namespace WebApplication1.Infrastrucure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClienteApplication>().As<IClienteApplication>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ProductApplication>().As<IProductApplication>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ClienteMapper>().As<IClienteMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();
        }
    }
}
