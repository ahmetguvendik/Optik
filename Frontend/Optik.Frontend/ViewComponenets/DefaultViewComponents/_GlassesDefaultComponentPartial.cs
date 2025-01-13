using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.GlassesDTO;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _GlassesDefaultComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _GlassesDefaultComponentPartial( IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5136/api/Glasses");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultGlassesDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}