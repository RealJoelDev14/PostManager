using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostManager.ApplicationCore.Common.Persistence;
using PostManager.Infrastructure.Common.Persistence;
using PostManager.Infrastructure.Common.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            AddPersistence(services);
            return services;
        }
        private static IServiceCollection AddPersistence(this IServiceCollection services)
        {

            services.AddDbContext<PostManagerContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            services.AddScoped<IPostRepository, PostRepository>();
            return services;
        }
    }
}
