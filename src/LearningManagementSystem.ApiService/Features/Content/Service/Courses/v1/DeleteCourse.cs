namespace LearningManagementSystem.ApiService.Features.Content.Service.Courses.v1;

public sealed record DeleteCourseRequest(Guid Id
) : IRequest<DeleteCourseResponse>;

public record DeleteCourseResponse(Guid? Id);

public class DeleteCourseRequestValidator : AbstractValidator<DeleteCourseRequest>
{
    public DeleteCourseRequestValidator()
    {
    }
}

public sealed class DeleteCourseRequestHandler : IRequestHandler<DeleteCourseRequest, DeleteCourseResponse>
{
    public async Task<DeleteCourseResponse> Handle(DeleteCourseRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}