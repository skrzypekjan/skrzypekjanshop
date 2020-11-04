using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkrzypekjanShop.Models;

namespace SkrzypekjanShop.Controllers
{
    public class BasketController : Controller
    {

        private static List<Product> basket = new List<Product>();
        List<Product> products = ProductController.products;
        private static double basketPrice;
        
        // GET: Basket
        public ActionResult Index()
        {
            Math.Round(basketPrice, 2, MidpointRounding.AwayFromZero);
            ViewBag.basketPrice = "Total price: " + String.Format("{0:0.00}", basketPrice);
            return View(basket);
        }

        public ActionResult Message()
        {
            return View();
        }

        // GET: Basket/Add
        public ActionResult Add(int id)
        {
            try
            {
                var product = products.FirstOrDefault(x => x.ProductId == id);
                basketPrice += product.Price;
                basket.Add(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(basket);
            }
        }

        // GET: BasketController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var product = products.FirstOrDefault(x => x.ProductId == id);
                basketPrice -= product.Price;
                basket.Remove(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(basket);
            }
        }
    }
}
