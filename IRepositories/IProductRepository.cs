namespace ELDOKKAN.Repositories;
public interface IProductRepository : IRepository<Product>
{
    IEnumerable<Product> SearchByName(string productName);
}