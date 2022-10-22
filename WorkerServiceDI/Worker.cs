using DIDemoLib;

namespace WorkerServiceDI
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IMesseges _messeges;

        public Worker(ILogger<Worker> logger, IMesseges messeges)
        {
            _logger = logger;
            _messeges = messeges;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogError(_messeges.SayHello());
                _logger.LogError(_messeges.SayGoodBye());

                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}