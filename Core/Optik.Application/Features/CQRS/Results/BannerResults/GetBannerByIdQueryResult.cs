namespace Optik.Application.Features.CQRS.Results.BannerResults;

public class GetBannerByIdQueryResult
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string ImageURL { get; set; }
    public object Image { get; set; }
}