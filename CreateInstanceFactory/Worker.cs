using CreateInstanceFactory.Interfaces;
using CreateInstanceFactory.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CreateInstanceFactory
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceFactory _serviceFactory;

        public Worker(ILogger<Worker> logger,
                      IServiceFactory serviceFactory)
        {
            _logger = logger;
            _serviceFactory = serviceFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var service = _serviceFactory.GetByType(typeof(TypeThree));
            await service.Execute();

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
