using LearningManagementSystem.Web.Infrastructure.Api;
using LearningManagementSystem.Shared.Authorization;
using LearningManagementSystem.Web.Components;
using Microsoft.AspNetCore.Components;

namespace LearningManagementSystem.Web.Pages.Auth;

public partial class ForgotPassword
{
    private readonly ForgotPasswordCommand _forgotPasswordRequest = new();
    private FshValidation? _customValidation;
    private bool BusySubmitting { get; set; }

    [Inject]
    private IApiClient UsersClient { get; set; } = default!;

    private string Tenant { get; set; } = TenantConstants.Root.Id;

    private async Task SubmitAsync()
    {
        BusySubmitting = true;

        await ApiHelper.ExecuteCallGuardedAsync(
            () => UsersClient.ForgotPasswordEndpointAsync(Tenant, _forgotPasswordRequest),
            Toast,
            _customValidation);

        BusySubmitting = false;
    }
}
