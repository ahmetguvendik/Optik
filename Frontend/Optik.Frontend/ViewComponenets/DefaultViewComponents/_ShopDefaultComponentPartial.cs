using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.ShopDTOs;

namespace Optik.Frontend.ViewComponenets.DefaultViewComponents;

public class _ShopDefaultComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _ShopDefaultComponentPartial( IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5136/api/Shop");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultShopDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}