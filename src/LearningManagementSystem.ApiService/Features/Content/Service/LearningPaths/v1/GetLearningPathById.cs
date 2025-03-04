namespace LearningManagementSystem.ApiService.Features.Content.Service.LearningPaths.v1;

public sealed record GetLearningPathByIdRequest(Guid Id
) : IRequest<GetLearningPathByIdResponse>;

public record GetLearningPathByIdResponse(Guid? Id);

public class GetLearningPathByIdRequestValidator : AbstractValidator<GetLearningPathByIdRequest>
{
    public GetLearningPathByIdRequestValidator()
    {
    }
}

public sealed class
    GetLearningPathByIdRequestHandler : IRequestHandler<GetLearningPathByIdRequest, GetLearningPathByIdResponse>
{
    public async Task<GetLearningPathByIdResponse> Handle(GetLearningPathByIdRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}