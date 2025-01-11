namespace Optik.Application.Features.CQRS.Results.ContactResults;

public class GetContactByIdQueryResult
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}