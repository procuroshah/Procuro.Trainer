using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using LearningManagementSystem.ApiService.Features.Content.Service.Courses.v1;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.ApiService.Features.Content.Service.Courses;

public static class CourseEndpoint
{
    internal static RouteHandlerBuilder MapGetCourseByIdEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/{id:guid}", async (Guid id, ISender mediator, 
                CancellationToken cancellationToken) =>
            {
                var response = await mediator.Send(new GetCourseByIdRequest(id), cancellationToken);
                return Results.Ok(response);
            })
            .WithName(nameof(MapGetCourseByIdEndpoint).Replace("Map",""))
            .WithSummary("Gets a course")
            .WithDescription("Gets a course by course identifier")
            .Produces<CourseResponse>()
            .RequirePermission("Permissions.Courses.View")
            .MapToApiVersion(1);
    }
    internal static RouteHandlerBuilder MapSearchCoursesEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/search", async ([FromBody] SearchCoursesRequest request, ISender mediator, 
                CancellationToken cancellationToken) =>
            {
                var response = await mediator.Send(request, cancellationToken);
                return Results.Ok(response);
            })
            .WithName(nameof(MapSearchCoursesEndpoint).Replace("Map",""))
            .WithSummary("Deletes a course")
            .WithDescription("Deletes a course and its dependencies.")
            .Produces<PagedList<CourseResponse>>()
            .RequirePermission("Permissions.Courses.Search")
            .MapToApiVersion(1);
    }
    internal static RouteHandlerBuilder MapAddUpdateCourseEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/", async (AddUpdateCourseRequest request, ISender mediator, 
                CancellationToken cancellationToken) =>
            {
                var response = await mediator.Send(request, cancellationToken);
                return Results.Ok(response);
            })
            .WithName(nameof(MapAddUpdateCourseEndpoint).Replace("Map",""))
            .WithSummary("Creates or updates a course")
            .WithDescription("Updates a course if it exists, otherwise creates a new course")
            .Produces<AddUpdateCourseResponse>(StatusCodes.Status200OK, "The course was created or updated successfully")
            .RequirePermission("Permissions.Courses.Create")
            .MapToApiVersion(1);
    }
    internal static RouteHandlerBuilder MapDeleteCourseEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator, 
                CancellationToken cancellationToken) =>
            {
                var response = await mediator.Send(new DeleteCourseRequest(id), cancellationToken);
                return Results.Ok(response);
            })
            .WithName(nameof(MapDeleteCourseEndpoint).Replace("Map",""))
            .WithSummary("Deletes a course")
            .WithDescription("Deletes a course and its dependencies.")
            .Produces(StatusCodes.Status200OK)
            .RequirePermission("Permissions.Courses.Delete")
            .MapToApiVersion(1);
    }
}