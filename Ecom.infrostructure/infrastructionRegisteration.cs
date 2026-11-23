using Ecom.Core.Interfaces;
using Ecom.infrostructure.Data;
using Ecom.infrostructure.Repositries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.infrostructure
{
    public static  class infrastructionRegisteration   
    {
        public static IServiceCollection infrastructureConfigurat(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepositry<>), typeof(CenericRepositry<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContex>(op =>
            {
                op.UseSqlite("Data Source=EcomDb.db");
            });
            return services;
        }
    }
}
