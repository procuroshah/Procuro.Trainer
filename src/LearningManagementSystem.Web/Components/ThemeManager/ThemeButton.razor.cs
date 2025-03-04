using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace LearningManagementSystem.Web.Components.ThemeManager;

public partial class ThemeButton
{
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
}
