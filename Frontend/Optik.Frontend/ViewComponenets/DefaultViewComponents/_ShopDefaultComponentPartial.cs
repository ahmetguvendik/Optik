using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _ShopDefaultComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}