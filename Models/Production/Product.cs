namespace ShopSystemAPI.Models.Production;

public class Product : BaseEntity<int>
{
    public string Name { get; set; }
    public Brand Brand { get; set; }
    public Category Category { get; set; }
    public short ModelYear { get; set; }
    public decimal Price { get; set; }

    public Product(string name, Brand brand, Category category, short modelYear, decimal price)
    {
        Name = name;
        Brand = brand;
        Category = category;
        ModelYear = modelYear;
        Price = price;
    }

    protected Product() {}
}