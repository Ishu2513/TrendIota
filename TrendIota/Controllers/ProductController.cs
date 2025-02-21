using Microsoft.AspNetCore.Mvc;
using TrendIota.Models;

namespace TrendIota.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
<<<<<<< HEAD
                new Product { ID = 1, Name = "Leather Handbag", Price = 49.99M, ImageUrl = "/images/img1.png", Description = "Modern and stylish handbag." },
                new Product { ID = 2, Name = "Travel Backpack", Price = 59.99M, ImageUrl = "/images/img2.png", Description = "Durable and spacious backpack." },
                new Product { ID = 3, Name = "Laptop Bag", Price = 79.99M, ImageUrl = "/images/img3.png", Description = "Elegant leather laptop bag." },
                new Product { ID = 4, Name = "Tote Bag", Price = 39.99M, ImageUrl = "/images/img4.png", Description = "Versatile tote bag for daily use." },
                new Product { ID = 5, Name = "Duffel Bag", Price = 99.99M, ImageUrl = "/images/img5.png", Description = "Luxury handbag with premium quality." }
=======
                new Product { ID = 1, Name = "TrendiBag A", Price = 49.99M, ImageUrl = "/images/bagA.jpg", Description = "Modern and stylish handbag." },
                new Product { ID = 2, Name = "TrendiBag B", Price = 59.99M, ImageUrl = "/images/bagB.jpg", Description = "Durable and spacious backpack." },
                new Product { ID = 3, Name = "TrendiBag C", Price = 79.99M, ImageUrl = "/images/bagC.jpg", Description = "Elegant leather laptop bag." },
                new Product { ID = 4, Name = "TrendiBag D", Price = 39.99M, ImageUrl = "/images/bagD.jpg", Description = "Versatile tote bag for daily use." },
                new Product { ID = 5, Name = "TrendiBag E", Price = 99.99M, ImageUrl = "/images/bagE.jpg", Description = "Luxury handbag with premium quality." }
>>>>>>> 70091ebbccf3020a259e5ba91303008d292c5dff
            };

            return View(products);
        }
    }
}
