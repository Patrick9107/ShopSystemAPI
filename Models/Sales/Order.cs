using ShopSystemAPI.Models.Production;

namespace ShopSystemAPI.Models.Sales;

public class Order : BaseEntity<int>
{
    public Customer Customer { get; set; }
    
    public OrderStatus Status { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public DateTime RequiredDate { get; set; }
    
    public DateTime DeliveredDate { get; set; }
    
    public Store Store { get; set; }
    
    public Staff Staff { get; set; }

    public Order(Customer customer, OrderStatus status, DateTime orderDate, DateTime requiredDate, DateTime deliveredDate, Store store, Staff staff)
    {
        Customer = customer;
        Status = status;
        OrderDate = orderDate;
        RequiredDate = requiredDate;
        DeliveredDate = deliveredDate;
        Store = store;
        Staff = staff;
    }

    protected Order() { }
}