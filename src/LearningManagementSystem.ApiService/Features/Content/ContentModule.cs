using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Identity.Roles.Endpoints;
using FSH.Framework.Infrastructure.Persistence;
using LearningManagementSystem.ApiService.Features.Content.Service.Courses;
using LearningManagementSystem.ApiService.Infrastructure.EfCore;

namespace LearningManagementSystem.ApiService.Features.Content;

public static class ContentModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() : base("content") { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var contentGroup = app.MapGroup("courses").WithTags("courses");
            contentGroup.MapAddUpdateCourseEndpoint();
            contentGroup.MapDeleteCourseEndpoint();
            contentGroup.MapGetCourseByIdEndpoint();
        }
    }

    public static WebApplicationBuilder RegisterContentModule(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        return builder;
    }
    public static WebApplication UseCatalogModule(this WebApplication app)
    {
        return app;
    }
}