namespace CustomerApi.Controllers.Dtos.Update;

public class AddressUpdateDto
{
    public string? StreetName { get; set; }
    public string? StreetNumber { get; set; }
    public string? PostalCode { get; set; }
    public string? CountryCode { get; set; }
    public string? City { get; set; }
}
