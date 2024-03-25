using WebApplicationn8.Models;
using Microsoft.AspNetCore.Mvc;


namespace WebApplicationn8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product {ID = 1, Name = "iPhone 13", Price = 899.00m, CreatedDate = DateTime.Now },
                new Product {ID = 2, Name = "MacBook Air", Price = 1199.00m, CreatedDate = DateTime.Now.AddMinutes(10) },
                new Product {ID = 3, Name = "iPad Air", Price = 649.00m, CreatedDate = DateTime.Now.AddMinutes(20) },
                new Product {ID = 4, Name = "Apple Watch Series 7", Price = 459.00m, CreatedDate = DateTime.Now.AddMinutes(30) },
                new Product {ID = 5, Name = "Amazon Kindle Paperwhite", Price = 129.99m, CreatedDate = DateTime.Now.AddMinutes(40) },
                new Product {ID = 6, Name = "PlayStation 5", Price = 599.00m, CreatedDate = DateTime.Now.AddMinutes(50) },
                new Product {ID = 7, Name = "Fitbit Charge 5", Price = 179.95m, CreatedDate = DateTime.Now.AddHours(1) }

            };

            return View(products);
        }
    }
}
