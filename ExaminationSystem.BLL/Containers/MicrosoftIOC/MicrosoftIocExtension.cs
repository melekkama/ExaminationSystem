using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.BLL.Managers;
using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Contexts;
using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Repositories;
using ExaminationSystem.DAL.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace ExaminationSystem.BLL.Containers.MicrosoftIOC;

public static class MicrosoftIocExtension
{
    public static void AddDependencies(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string connectionString =
            configuration.GetConnectionString(Environment.MachineName) ??
            configuration.GetConnectionString(configuration.GetRequiredSection("DefaultConnectionString").Value);
        string? migrationName = Assembly.GetCallingAssembly().GetName().Name;

        services.AddTransient<DbContext, ApplicationDbContext>();

        services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer(connectionString, sqlOpt =>
                sqlOpt.MigrationsAssembly(migrationName)
                )
        );

        #region Repositoryies
        services.AddTransient(typeof(IGenericRepository<>), typeof(EfGenericRepository<>));
        #endregion
        #region Services
        services.AddTransient(typeof(IGenericService<>), typeof(GenericManager<>));
        //services.AddScoped<IService, Manager>();

        #endregion

    }
    public static void AddType<T>(this IServiceCollection services, Assembly? assembly = null)
    {
        assembly ??= Assembly.GetCallingAssembly();
        List<Type> types = assembly.GetTypes()
            .Where(x => x.BaseType is not null && x.BaseType.Equals(typeof(T)))
            .ToList();
        types.ForEach(type => services.AddTransient(type));
    }
}