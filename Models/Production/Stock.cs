using ShopSystemAPI.Models.Sales;

namespace ShopSystemAPI.Models.Production;

public class Stock : BaseEntity<int>
{
    public Product Product { get; set; }
    public Store Store { get; set; }
    public int Quantity { get; set; }

    public Stock(Product product, Store store, int quantity)
    {
        Product = product;
        Store = store;
        Quantity = quantity;
    }

    protected Stock() { }
}