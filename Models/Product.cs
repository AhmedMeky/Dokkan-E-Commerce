namespace ELDOKKAN.Models;
public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public int? CategoryID { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }

    // navigation properties
    public virtual Category Category { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}