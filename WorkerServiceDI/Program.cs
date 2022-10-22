using DIDemoLib;
using WorkerServiceDI;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services
            .AddHostedService<Worker>()
            .AddTransient<IMesseges, Messeges>();

    })
    .Build();

await host.RunAsync();
