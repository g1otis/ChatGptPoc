namespace CustomerApi.Controllers.Dtos.Create;

public class TelephoneCreateDto
{
    public required string TelCountryExtension { get; set; }
    public required string TelNumber { get; set; }
    public required string Type { get; set; }  // Could be 'Home', 'Mobile', 'Work'
}
