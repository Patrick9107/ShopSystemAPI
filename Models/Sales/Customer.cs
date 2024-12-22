namespace ShopSystemAPI.Models.Sales;

public class Customer : BaseEntity<int>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public Contact Contact { get; set; }
    
    public Address Address { get; set; }

    public Customer(string firstName, string lastName, Contact contact, Address address)
    {
        FirstName = firstName;
        LastName = lastName;
        Contact = contact;
        Address = address;
    }

    protected Customer() { }
}