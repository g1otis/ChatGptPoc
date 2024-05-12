namespace CustomerApi.Controllers.Dtos.Create;

public class CustomerCreateDto
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required OriginCreateDto Origin { get; set; }
    public required AddressCreateDto Address { get; set; }
    public required List<TelephoneCreateDto> Telephones { get; set; }
}
