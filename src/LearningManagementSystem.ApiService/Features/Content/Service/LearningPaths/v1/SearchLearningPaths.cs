namespace LearningManagementSystem.ApiService.Features.Content.Service.LearningPaths.v1;

public sealed record SearchLearningPathsRequest(Guid? Id, string? Title, string? CourseTitle
) : IRequest<SearchLearningPathsResponse>;

public record SearchLearningPathsResponse(Guid Id, string Title);

public class SearchLearningPathsRequestValidator : AbstractValidator<SearchLearningPathsRequest>
{
    public SearchLearningPathsRequestValidator()
    {
    }
}

public sealed class
    SearchLearningPathsRequestHandler : IRequestHandler<SearchLearningPathsRequest, SearchLearningPathsResponse>
{
    public async Task<SearchLearningPathsResponse> Handle(SearchLearningPathsRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}