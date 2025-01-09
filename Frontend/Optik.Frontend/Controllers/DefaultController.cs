using Microsoft.AspNetCore.Mvc;

namespace Optik.Frontend.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}