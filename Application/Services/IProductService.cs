namespace ELDOKKAN.Application.Services;
public interface IProductService
{
    GetAllProductDTO GetProductById(int ProductId);
    IEnumerable<GetAllProductDTO> GetAllProducts();
    GetAllProductDTO AddProduct(CreateProductDTO createProductDto);
    bool UpdateProduct(int ProductId, UpdateProductDTO updateProductDto);
    bool DeleteProduct(int ProductId);
} 