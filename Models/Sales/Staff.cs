namespace ShopSystemAPI.Models.Sales;

public class Staff : BaseEntity<int>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public Contact Contact { get; set; }
    
    public bool IsActive { get; set; }
    
    public Staff? Manager { get; set; }

    public Staff(string firstName, string lastName, Contact contact, bool isActive, Staff? manager)
    {
        FirstName = firstName;
        LastName = lastName;
        Contact = contact;
        IsActive = isActive;
        Manager = manager;
    }

    protected Staff() { }
}