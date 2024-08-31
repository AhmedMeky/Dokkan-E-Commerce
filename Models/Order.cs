namespace ELDOKKAN.Models;

public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime? OrderDate { get; set; }

    // navigation properties
    public virtual Customer Customer { get; set; }
    public virtual ICollection<OrderDetails> OrderDetails { get; set; }
}