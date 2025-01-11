using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.UILayoutViewComponents;

public class _HeaderUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}