using FSH.Framework.Core.Paging;

namespace LearningManagementSystem.ApiService.Features.Content.Service.Courses.v1;

public class SearchCoursesRequest : PaginationFilter, IRequest<PagedList<CourseResponse>>
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
}


public class SearchCoursesRequestValidator : AbstractValidator<SearchCoursesRequest>
{
    public SearchCoursesRequestValidator()
    {
    }
}

public sealed class SearchCoursesRequestHandler 
    : IRequestHandler<SearchCoursesRequest, PagedList<CourseResponse>>
{
    public async Task<PagedList<CourseResponse>> Handle(SearchCoursesRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}