using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.ContactDTOs;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _ContactDefaultComponentPartial : ViewComponent
{
    public  IViewComponentResult Invoke()
    {
        return View();
    }
}