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
            ViewBag.basketPrice = "Total price: " + basketPrice;
            return View(basket);
        }

        // GET: Basket/Add
        public ActionResult Add(int id)
        {
            try
            {
                var product = products.FirstOrDefault(x => x.ProductId == id);
                basketPrice += product.Price;
                basket.Add(product);
                ViewBag.busketPrice = basketPrice;
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
                ViewBag.busketPrice = basketPrice;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(basket);
            }
        }
    }
}
