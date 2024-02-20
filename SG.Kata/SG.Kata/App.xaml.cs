using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SG.DEPOT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SG.Kata
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App :System.Windows.Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            DEPOT.Parametre.SGConfiguration.ConnectingString = Configuration.GetSection("ConnectionStrings")[DEPOT.Parametre.SGConfiguration.ConnectingStringKey];

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var homeScreen = ServiceProvider.GetRequiredService<Kata>();
            homeScreen.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            IServices(services);
            services.AddDbContext<SGDbContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });
            services.AddTransient(typeof(Kata));
        }

        private void IServices(IServiceCollection services)
        {
            Application.DI.DependancyInjection.IServices(services);
        }
    }
}
