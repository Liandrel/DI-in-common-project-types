using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsDI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((_, services) =>
                {
                    services
                    .AddTransient<IMesseges, Messeges>()
                    .AddTransient<Form1>();
                });

            var host = builder.Build();
            using var scope = host.Services.CreateScope();

            try
            {
                var services = scope.ServiceProvider;

                ApplicationConfiguration.Initialize();

                var frm = services.GetRequiredService<Form1>();
                Application.Run(frm);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured {ex.Message}");
            }
            
            
        }
    }
}