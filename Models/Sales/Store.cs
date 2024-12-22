using ShopSystemAPI.Models.Production;

namespace ShopSystemAPI.Models.Sales;

public class Store : BaseEntity<int>
{
    public List<Stock> Stocks { get; set; } = [];
    
    public List<Staff> Staffs { get; set; } = [];
    
    public string Name { get; set; }
    
    public Address Address { get; set; }
    
    public Contact Contact { get; set; }

    public Store(string name, Address address, Contact contact)
    {
        Name = name;
        Address = address;
        Contact = contact;
    }

    protected Store() { }
}