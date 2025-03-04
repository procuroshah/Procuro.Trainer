using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using LearningManagementSystem.ApiService.Infrastructure.EfCore;
using LearningManagementSystem.ApiService.Infrastructure.EfCore.Configurations;

namespace LearningManagementSystem.ApiService.Infrastructure.Extensions;

public static class WebAppBuilderExtensions
{
    public static WebApplicationBuilder RegisterModules(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        
        //register validators
        builder.Services.AddValidatorsFromAssemblyContaining<Program>();

        //register mediatr
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblyContaining<Program>();
        });

        // add db contexts
        builder.Services.BindDbContext<ApplicationDbContext>();
        builder.Services.AddScoped<IDbInitializer, ApplicationDbInitializer>();

        return builder;
    } 
}