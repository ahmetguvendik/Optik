using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _ContactDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}