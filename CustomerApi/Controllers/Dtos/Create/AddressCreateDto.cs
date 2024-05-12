namespace CustomerApi.Controllers.Dtos.Create;

public class AddressCreateDto
{
    public required string StreetName { get; set; }
    public required string StreetNumber { get; set; }
    public required string PostalCode { get; set; }
    public required string CountryCode { get; set; }
    public required string City { get; set; }
}
