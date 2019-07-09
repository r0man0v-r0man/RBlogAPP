using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RBlog.DATA.Entities;
using RBlog.Repository;
using RBlog.Repository.Data;
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
            serviceCollection.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DataContext>();
        }
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(DataRepository<>));
        }
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPostService, PostService>();
        }
        private static string GetDataConnectionStringFromConfig()
        {
            return new DataBaseConfiguration().GetDataConnectionString();
        }
    }
}
