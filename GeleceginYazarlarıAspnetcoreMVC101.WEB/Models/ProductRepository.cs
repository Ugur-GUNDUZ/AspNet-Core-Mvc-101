namespace GeleceginYazarlarıAspnetcoreMVC101.WEB.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 4, Name = "kalem 1", Price = 100, Stock = 200 },
            new Product { Id = 5, Name = "kalem 2", Price = 200, Stock = 100 },
            new Product { Id = 6, Name = "kalem 3", Price = 300, Stock = 50 }
        };
        public List<Product> GetAll() => _products.ToList();
        public void AddProduct(Product newProduct) => _products.Add(newProduct);
        public void UpdateProduct(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == updateProduct.Id);
            if (hasProduct == null)
            {
                throw new Exception($"bu İd({updateProduct.Id}) ye bulunamadı.");
            }
            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;
            var index = _products.FindIndex(p => p.Id == updateProduct.Id);
            _products[index] = hasProduct;
        }
        public void DeleteProduct(int id)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == id);
            if (hasProduct == null)
            {
                throw new Exception($"bu İd({id}) ye bulunamadı.");
            }
            _products.Remove(hasProduct);
        }
    }
}
