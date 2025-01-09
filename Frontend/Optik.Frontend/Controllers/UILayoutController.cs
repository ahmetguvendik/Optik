using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.Controllers;

public class UILayoutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}