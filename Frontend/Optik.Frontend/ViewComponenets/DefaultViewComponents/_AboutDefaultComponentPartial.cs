using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.AboutDTOs;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _AboutDefaultComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AboutDefaultComponentPartial( IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5136/api/About");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}