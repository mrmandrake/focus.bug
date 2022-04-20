using Avalonia.Web.Blazor;

namespace focus.bug.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<focus.bug.App>()
            .SetupWithSingleViewLifetime();
    }
}