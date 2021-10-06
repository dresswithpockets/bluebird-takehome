using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Bluebird.Background
{
    public class MarketOrderBackgroundService : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
            => Task.Run(() => InternalExecuteAsync(stoppingToken), CancellationToken.None);

        private async Task InternalExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    // Do scheduled processing here
                }
            }
            catch (Exception exception) when (exception is TaskCanceledException or OperationCanceledException)
            {
            }
        }
    }
}