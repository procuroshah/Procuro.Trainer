using LearningManagementSystem.ApiService.Features.Content.Data;

namespace LearningManagementSystem.ApiService.Features.Content.Service.LearningPaths.v1;

public sealed record AddUpdateLearningPathRequest(
    Guid? Id,
    string Title
) : IRequest<AddUpdateLearningPathResponse>;

public record AddUpdateLearningPathResponse(Guid Id);

public class AddUpdateLearningPathRequestValidator : AbstractValidator<AddUpdateLearningPathRequest>
{
    public AddUpdateLearningPathRequestValidator()
    {
    }
}

public sealed class
    AddUpdateLearningPathRequestHandler : IRequestHandler<AddUpdateLearningPathRequest, AddUpdateLearningPathResponse>
{
    public async Task<AddUpdateLearningPathResponse> Handle(AddUpdateLearningPathRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}