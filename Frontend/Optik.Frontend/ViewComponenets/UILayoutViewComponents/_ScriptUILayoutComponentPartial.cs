using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.UILayoutViewComponents;

public class _ScriptUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}