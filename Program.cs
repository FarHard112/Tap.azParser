using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TapazParser.BinaAZ;
using TapazParser.BinaAZ.Abstract;
using TapazParser.BinaAZ.Concrete;

namespace TapazParser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<ChooseParser>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<ChooseParser>();
                    services.AddTransient<Form1>();
                    services.AddTransient<Binaaz>();
                    services.AddTransient<IBinaaz, BinaazConcrete>();
                });
        }
    }
}