using Asp.Versioning.Conventions;
using Carter;
using FSH.Framework.Infrastructure.Auth;

namespace LearningManagementSystem.ApiService.Infrastructure.Extensions;

public static class AppBuilderExtensions
{

    public static WebApplication UseModules(this WebApplication app)
    {
        ArgumentNullException.ThrowIfNull(app);
        
        //register api versions
        var versions = app.NewApiVersionSet()
            .HasApiVersion(1)
            .ReportApiVersions()
            .Build();

        //map versioned endpoint
        var endpoints = app.MapGroup("api/v{version:apiVersion}").WithApiVersionSet(versions);
        endpoints.MapCarter();
        return app;
    }
}