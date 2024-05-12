namespace CustomerApi.Models;

public class Telephone
{
    public int Id { get; set; }
    public string TelCountryExtension { get; set; }
    public string TelNumber { get; set; }
    public string Type { get; set; } // Consider using an enum for Type (Home, Mobile, Work)

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
