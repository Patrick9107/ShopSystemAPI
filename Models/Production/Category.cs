namespace ShopSystemAPI.Models.Production;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }

    protected Category() { }
}