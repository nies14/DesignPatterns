public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product product);
}

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAllProducts() => _context.Products.ToList();
    public Product GetProductById(int id) => _context.Products.Find(id);
    public void AddProduct(Product product) => _context.Products.Add(product);
}
