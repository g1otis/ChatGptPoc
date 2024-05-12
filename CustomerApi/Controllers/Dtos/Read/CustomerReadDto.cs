namespace CustomerApi.Controllers.Dtos.Read;

public class CustomerReadDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required OriginReadDto Origin { get; set; }
    public required AddressReadDto Address { get; set; }
    public required List<TelephoneReadDto> Telephones { get; set; }
}
