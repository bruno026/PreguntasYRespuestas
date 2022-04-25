using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Data;
using Core.Services;
using Service;

namespace PreguntasYResupuestas.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContextPool<PreguntasDBContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("Default"),
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly("Data");
                        sqlOptions.EnableRetryOnFailure(3);
                    }));
        }

        public static void ConfigureDependencyServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IHighScoreService, HighScoreService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<INewGameService, NewGameService>();
            services.AddTransient<ICategoryService, CategoryService>();


        }
    }
}
