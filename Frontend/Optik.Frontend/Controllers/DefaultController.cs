using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.ContactDTOs;

namespace Optik.Frontend.Controllers;

public class DefaultController : Controller
{
    public IHttpClientFactory _httpClientFactory;

    public DefaultController( IHttpClientFactory httpClientFactory )
    {
         _httpClientFactory = httpClientFactory;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }
    

    [HttpPost]
    public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
    {
        
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createContactDto);
        StringContent stringContent = new StringContent(jsonData, encoding: Encoding.UTF8, "application/json");
        var response = await client.PostAsync("http://localhost:5136/api/Contact", stringContent);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "Default");
        }

        return View();

    }
    
}