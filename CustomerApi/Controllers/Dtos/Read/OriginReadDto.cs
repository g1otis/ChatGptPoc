namespace CustomerApi.Controllers.Dtos.Read;

public class OriginReadDto
{
    public DateTime DateOfBirth { get; set; }
    public required string CountryOfBirth { get; set; }
    public required string Gender { get; set; }
}
