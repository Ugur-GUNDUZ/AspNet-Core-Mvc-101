using GeleceginYazarlarıAspnetcoreMVC101.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeleceginYazarlarıAspnetcoreMVC101.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository _productRepository;
        public ProductsController()
        {
            _productRepository = new ProductRepository();
            //if(!_productRepository.GetAll().Any()) 
            //{
            //    _productRepository.AddProduct(new Product { Id = 1, Name = "kalem 1", Price = 100, Stock = 200 });
            //    _productRepository.AddProduct(new Product { Id = 2, Name = "kalem 2", Price = 200, Stock = 100 });
            //    _productRepository.AddProduct(new Product { Id = 3, Name = "kalem 3", Price = 300, Stock = 50 });    
            //}

        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
        public IActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
