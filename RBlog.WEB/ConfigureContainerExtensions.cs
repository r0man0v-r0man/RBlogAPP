using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RBlog.Repository;
using RBlog.Repository.Data;
using RBlog.Repository.Identity;
using RBlog.Service;
using RBlog.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBlog.WEB
{
    public static class ConfigureContainerExtensions
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
                                        string dataConnectionString = null,
                                        string authConnectionString = null)
        {
            serviceCollection.AddDbContext<DataContext>(options =>
                options.UseSqlServer(dataConnectionString ?? GetDataConnectionStringFromConfig()));
            serviceCollection.AddDbContext<ApplicationIdentityContext>(options =>
                options.UseSqlServer(authConnectionString ?? GetAuthConnectionStringFromConfig()));
            serviceCollection.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityContext>();
        }
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(DataRepository<>));
        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPostService, PostService>();
        }

        private static string GetAuthConnectionStringFromConfig()
        {
            return new DataBaseConfiguration().GetAuthConnectionString();
        }

        private static string GetDataConnectionStringFromConfig()
        {
            return new DataBaseConfiguration().GetDataConnectionString();
        }
    }
}
