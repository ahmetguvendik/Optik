using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _TestimonialDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}