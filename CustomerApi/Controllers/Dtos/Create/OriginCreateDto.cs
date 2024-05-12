namespace CustomerApi.Controllers.Dtos.Create;

public class OriginCreateDto
{
    public DateTime DateOfBirth { get; set; }
    public required string CountryOfBirth { get; set; }
    public required string Gender { get; set; }
}
