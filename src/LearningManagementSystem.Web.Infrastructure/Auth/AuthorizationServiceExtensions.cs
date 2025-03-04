using System.Security.Claims;
using LearningManagementSystem.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace LearningManagementSystem.Web.Infrastructure.Auth;

public static class AuthorizationServiceExtensions
{
    public static async Task<bool> HasPermissionAsync(this IAuthorizationService service, ClaimsPrincipal user, string action, string resource)
    {
        return (await service.AuthorizeAsync(user, null, FshPermission.NameFor(action, resource))).Succeeded;
    }
}
