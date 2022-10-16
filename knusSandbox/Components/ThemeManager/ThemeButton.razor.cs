using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace knusSandbox.Components.ThemeManager;

public partial class ThemeButton
{
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
}