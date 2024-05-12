namespace CustomerApi.Controllers.Dtos.Update;

public class TelephoneUpdateDto
{
    public string? TelCountryExtension { get; set; }
    public string? TelNumber { get; set; }
    public string? Type { get; set; }  // Could be 'Home', 'Mobile', 'Work'
}
