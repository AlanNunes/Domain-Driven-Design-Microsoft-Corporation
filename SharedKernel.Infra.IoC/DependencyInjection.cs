using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.Application.Interfaces;
using SharedKernel.Application.Services;
using SharedKernel.Domain.Interfaces.Repositories;
using SharedKernel.Infra.Data.Context;
using SharedKernel.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedKernel.Infra.IoC
{
    public class DependencyInjection
    {
        public void Inject(IServiceCollection services, string connString)
        {
            services.AddDbContext<MicrosoftCorporationContext>(options => options.UseSqlServer(connString));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(IRepositoryBase<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IServiceAppBase<>), typeof(ServiceAppBase<>));
            services.AddScoped<IProductAppService, ProductAppService>();
        }
    }
}
