namespace LearningManagementSystem.ApiService.Features.Content.Service.Courses.v1;

public sealed record GetCourseByIdRequest(Guid Id
) : IRequest<CourseResponse>;

public record CourseResponse(
    Guid Id,
    string Title,
    string? Description,
    string? FullDescription);

public class GetCourseByIdRequestValidator : AbstractValidator<GetCourseByIdRequest>
{
    public GetCourseByIdRequestValidator()
    {
    }
}

public sealed class GetCourseByIdRequestHandler : IRequestHandler<GetCourseByIdRequest, CourseResponse>
{
    public async Task<CourseResponse> Handle(GetCourseByIdRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}