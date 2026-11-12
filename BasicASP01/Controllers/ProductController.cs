using Microsoft.AspNetCore.Mvc;
using BasicASP01.Models;
namespace BasicASP01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            var Product1 = new Models.Product
            {
               Id = 01,
               Name = "Potato Lay",
               Price = 20.00m,
               Quantity = 100

            };
            var Product2 = new Models.Product
            {
                Id = 02,
                Name = "Coca Cola",
                Price = 15.00m,
                Quantity = 200
            };
            var Product3 = new Models.Product
            {
                Id = 03,
                Name = "Pepsi",
                Price = 15.00m,
                Quantity = 200
            };
            var Product4 = new Models.Product
            {
                Id = 04,
                Name = "Fanta",
                Price = 15.00m,
                Quantity = 200
            };
            var Product5 = new Models.Product
            {
                Id = 05,
                Name = "Sprite",
                Price = 15.00m,
                Quantity = 200
            };
            var Product6 = new Models.Product
            {
                Id = 06,
                Name = "M150",
                Price = 15.00m,
                Quantity = 200
            };
            var Product7 = new Models.Product
            {
                Id = 07,
                Name = "Red Bull",
                Price = 15.00m,
                Quantity = 200
            };
            var Product8 = new Models.Product
            {
                Id = 08,
                Name = "Mama",
                Price = 07.00m,
                Quantity = 200
            };
            var Product9 = new Models.Product
            {
                Id = 09,
                Name = "",
                Price = 07.00m,
                Quantity = 200
            };
            //var products = new List<Models.Product> { product, product2, product3, product4, product5, product6, product7 };
            var Product = new List<Models.Product>();
            Product.Add(Product1);
            Product.Add(Product2);
            Product.Add(Product3);
            Product.Add(Product4);
            Product.Add(Product5);
            Product.Add(Product6);
            Product.Add(Product7);
            Product.Add(Product8);
            Product.Add(Product9);

            int pageSize = 3;
            int totalItems = Product.Count;
            int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var pagedProduct = Product
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(pagedProduct);
        }
    }
}
