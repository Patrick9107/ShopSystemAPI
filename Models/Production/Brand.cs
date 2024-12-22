namespace ShopSystemAPI.Models.Production;

public class Brand : BaseEntity<int>
{
    public string Name { get; set; }

    public Brand(string name)
    {
        Name = name;
    }

    protected Brand() { }
}