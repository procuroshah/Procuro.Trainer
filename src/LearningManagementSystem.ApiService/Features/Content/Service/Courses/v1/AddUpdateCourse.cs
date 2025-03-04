namespace LearningManagementSystem.ApiService.Features.Content.Service.Courses.v1;

public sealed record AddUpdateCourseRequest(
    Guid? Id,
    string Title,
    string? Description,
    string? FullDescription
    ) : IRequest<AddUpdateCourseResponse>;

public record AddUpdateCourseResponse(Guid? Id);

public class AddUpdateCourseRequestValidator : AbstractValidator<AddUpdateCourseRequest>
{
    public AddUpdateCourseRequestValidator()
    {
    }
}

public sealed class AddUpdateCourseHandler : IRequestHandler<AddUpdateCourseRequest, AddUpdateCourseResponse>
{
    public async Task<AddUpdateCourseResponse> Handle(AddUpdateCourseRequest request, 
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}