using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebApplication1.Application;
using WebApplication1.Application.Interfaces;
using WebApplication1.Application.Interfaces.Mappers;
using WebApplication1.Application.Mappers;
using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Domain.Core.Interfaces.Services;
using WebApplication1.Domain.Services;
using WebApplication1.Infrastrucure.CrossCutting.IOC;
using WebApplication1.Infrastrucure.Data.MSSqlcontext;
using WebApplication1.Infrastrucure.Data.Repositories;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<MSSqlContext>(options => options.UseSqlServer(connection));
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Model DDD", Version = "v1" });
            });
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteMapper, ClienteMapper>();
            services.AddScoped<IClienteApplication, ClienteApplication>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductMapper, ProductMapper>();
            services.AddScoped<IProductApplication, ProductApplication>();

            services.AddCors(o => o.AddPolicy("CorsPolicy", builder => {
                builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .WithOrigins("http://localhost:4200");
            }));
        }

        public void ConfigurationContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Model DDD"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
