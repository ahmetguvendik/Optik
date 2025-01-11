using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.UILayoutViewComponents;

public class _HeadUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}