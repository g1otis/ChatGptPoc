namespace CustomerApi.Controllers.Dtos.Read;

public class AddressReadDto
{
    public required string StreetName { get; set; }
    public required string StreetNumber { get; set; }
    public required string PostalCode { get; set; }
    public required string CountryCode { get; set; }
    public required string City { get; set; }
}
