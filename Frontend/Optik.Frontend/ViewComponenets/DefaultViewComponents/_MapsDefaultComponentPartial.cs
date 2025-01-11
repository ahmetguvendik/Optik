using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _MapsDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}