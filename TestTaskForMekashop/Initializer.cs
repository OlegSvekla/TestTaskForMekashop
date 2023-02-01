using Microsoft.AspNetCore.Cors.Infrastructure;
using NuGet.ContentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TestTaskForMekashop.DAL.Interfaces;
using TestTaskForMekashop.DAL.Repositories;
using TestTaskForMekashop.DOMAIN.Entity;
using TestTaskForMekashop.Service.Interfaces;
using TestTaskForMekashop.Service.Implementations;

namespace TestTaskForMekashop
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<User>, UserRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
