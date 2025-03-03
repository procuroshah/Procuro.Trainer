using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.ApiService.Common;

[ApiController]
[Route("api/LMS/[controller]")]
[Produces("application/json")]
#if !DEBUG
[Authorize]
#endif
public class ApiBaseController : ControllerBase
{
    private ISender? _mediator = null;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

}