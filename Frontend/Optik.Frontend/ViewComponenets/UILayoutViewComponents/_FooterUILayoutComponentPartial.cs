using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.UILayoutViewComponents;

public class _FooterUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}