namespace ELDOKKAN.Models;
public class OrderDetail
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }

    // navigation properties
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
}