using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _GlassesDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}