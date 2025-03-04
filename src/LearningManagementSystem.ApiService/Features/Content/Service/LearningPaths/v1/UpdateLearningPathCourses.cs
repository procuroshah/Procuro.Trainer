namespace LearningManagementSystem.ApiService.Features.Content.Service.LearningPaths.v1;

public sealed record UpdateLearningPathCoursesRequest(
    Guid LearningPathId,
    ICollection<Guid> CourseIds) 
    : IRequest<UpdateLearningPathCoursesResponse>;

public record UpdateLearningPathCoursesResponse(Guid? Id);

public class UpdateLearningPathCoursesRequestValidator : AbstractValidator<UpdateLearningPathCoursesRequest>
{
    public UpdateLearningPathCoursesRequestValidator()
    {
    }
}

public sealed class
    UpdateLearningPathCoursesRequestHandler : IRequestHandler<UpdateLearningPathCoursesRequest,
    UpdateLearningPathCoursesResponse>
{
    public async Task<UpdateLearningPathCoursesResponse> Handle(UpdateLearningPathCoursesRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}