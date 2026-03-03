using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Data;

public class MigrationHostedService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<MigrationHostedService> _logger;

    public MigrationHostedService(IServiceProvider serviceProvider,
        ILogger<MigrationHostedService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Starting database migration process...");

        using var scope = _serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        var retries = 5;

        while (retries > 0 && !stoppingToken.IsCancellationRequested)
        {
            try
            {
                _logger.LogInformation("Applying migrations...");
                await context.Database.MigrateAsync(stoppingToken);
                _logger.LogInformation("Database migration completed.");
                break;
            }
            catch (Exception ex)
            {
                retries--;
                _logger.LogWarning(ex, "Migration failed. Retrying in 5 seconds... ({Retries} left)", retries);
                await Task.Delay(5000, stoppingToken);
            }
        }

        if (retries == 0)
        {
            _logger.LogError("Migration failed after maximum retries.");
        }
    }
}