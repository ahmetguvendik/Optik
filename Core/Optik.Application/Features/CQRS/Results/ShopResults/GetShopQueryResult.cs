namespace Optik.Application.Features.CQRS.Results.ShopResults;

public class GetShopQueryResult
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}