using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _AboutDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}