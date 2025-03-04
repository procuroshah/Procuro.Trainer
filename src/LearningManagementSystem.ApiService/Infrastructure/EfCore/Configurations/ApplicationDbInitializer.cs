using FSH.Framework.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem.ApiService.Infrastructure.EfCore.Configurations;

public class ApplicationDbInitializer(ILogger<ApplicationDbInitializer> logger,
    ApplicationDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for catalog module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {

    }
}