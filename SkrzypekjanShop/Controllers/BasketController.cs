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

        // GET: Basket
        public ActionResult Index()
        {
            return View(basket);
        }

        // GET: Basket/Add
        public ActionResult Add(int id)
        {
            try
            {
                basket.Add(products.FirstOrDefault(x => x.ProductId == id));
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
                basket.Remove(products.FirstOrDefault(x => x.ProductId == id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(basket);
            }
        }
    }
}
