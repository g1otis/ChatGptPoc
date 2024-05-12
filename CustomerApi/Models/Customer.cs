namespace CustomerApi.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    // Add the new fields
    public Origin Origin { get; set; } // EF Core will handle this as a complex type
    public Address Address { get; set; } // EF Core will handle this as a complex type
    public ICollection<Telephone> Telephones { get; set; } // Optional and can have multiple values
    
    // Constructor to initialize the collection
    public Customer()
    {
        Telephones = new List<Telephone>();
    }
}
