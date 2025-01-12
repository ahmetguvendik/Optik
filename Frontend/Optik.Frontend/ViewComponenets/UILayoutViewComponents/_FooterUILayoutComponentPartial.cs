using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Optik.DTO.FooterDTOs;

namespace Optik.Frontend.ViewComponenets.UILayoutViewComponents;

public class _FooterUILayoutComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _FooterUILayoutComponentPartial( IHttpClientFactory httpClientFactory)
    {
         _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5136/api/Footer");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultFooterDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}