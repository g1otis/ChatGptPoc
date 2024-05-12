namespace CustomerApi.Controllers.Dtos.Update;

public class CustomerUpdateDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public OriginUpdateDto? Origin { get; set; }
    public AddressUpdateDto? Address { get; set; }
    public List<TelephoneUpdateDto>? Telephones { get; set; }
}
