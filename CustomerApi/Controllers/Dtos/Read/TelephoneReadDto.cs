namespace CustomerApi.Controllers.Dtos.Read;

public class TelephoneReadDto
{
    public required string TelCountryExtension { get; set; }
    public required string TelNumber { get; set; }
    public required string Type { get; set; }  // Could be 'Home', 'Mobile', 'Work'
}
