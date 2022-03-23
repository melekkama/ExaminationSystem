#nullable disable
using ExaminationSystem.BLL.Containers.MicrosoftIOC;
using ExaminationSystem.FormUI.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExaminationSystem.FormUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = Host.CreateDefaultBuilder()
                .ConfigureHostConfiguration(opt =>
                {
                    opt.SetBasePath(Directory.GetCurrentDirectory());
                    opt.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context,services) => {
                    services.AddDependencies(context.Configuration);
                    services.AddType<Form>();
                });

            var host =builder.Build();
            using IServiceScope serviceScope = host.Services.CreateScope();
            IServiceProvider services = serviceScope.ServiceProvider;
            var dbContext = services.GetRequiredService<DbContext>();
            dbContext.Database.Migrate();
            Application.Run(services.GetRequiredService<RegisterForm>());
        }
    }
}