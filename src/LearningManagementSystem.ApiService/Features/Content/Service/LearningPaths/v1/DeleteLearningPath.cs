namespace LearningManagementSystem.ApiService.Features.Content.Service.LearningPaths.v1;

public sealed record DeleteLearningPathRequest(Guid Id
) : IRequest<DeleteLearningPathResponse>;

public record DeleteLearningPathResponse(Guid? Id);

public class DeleteLearningPathRequestValidator : AbstractValidator<DeleteLearningPathRequest>
{
    public DeleteLearningPathRequestValidator()
    {
    }
}

public sealed class
    DeleteLearningPathRequestHandler : IRequestHandler<DeleteLearningPathRequest, DeleteLearningPathResponse>
{
    public async Task<DeleteLearningPathResponse> Handle(DeleteLearningPathRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}