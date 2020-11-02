using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkrzypekjanShop.Models;

namespace SkrzypekjanShop.Controllers
{
    public class ProductController : Controller
    {

        private static List<Product> products = new List<Product>()
        {
                new Product(){ ProductId = 1, Name = "T-shirt", Photo = "https://a.allegroimg.com/s512/03a495/6b2048ee4c3297c67532a2af90ae/KOSZULKA-T-SHIRT-MESKA-JHK-TSRA-150-CZARNA-XXL", Price = 16.20 },
                new Product(){ ProductId = 2, Name = "Trousers", Photo = "https://contents.mediadecathlon.com/p298255/ke8f7eea4f12af3b78b529dc7a0923f11/298255_default.jpg?format=auto&quality=60&f=800x0", Price = 15.50 },
                new Product(){ ProductId = 3, Name = "Cap", Photo = "https://az1.hatstoremedia.com/hatstore/images/4978_1/652/522/0/adjustable-black-basic-cap.jpg", Price = 9.99 },
                new Product(){ ProductId = 4, Name = "Blouse", Photo = "https://st2.depositphotos.com/4192645/6758/i/450/depositphotos_67585779-stock-photo-white-hoodie-design.jpg", Price = 20.20 },
                new Product(){ ProductId = 5, Name = "Shorts", Photo = "https://marvel-b1-cdn.bc0a.com/f00000000058595/cdn.shopify.com/s/files/1/0077/0432/products/Khakinators_5_LD_frontweb_400x.progressive.jpg?v=1596760301", Price = 12.90 },
                new Product(){ ProductId = 6, Name = "Sweater", Photo = "https://static.pullandbear.net/2/photos/2020/I/0/1/p/9553/351/804/9553351804_1_1_3.jpg?t=1603984271617", Price = 22.20 },
                new Product(){ ProductId = 7, Name = "T-shirt", Photo = "https://a.allegroimg.com/s512/03a495/6b2048ee4c3297c67532a2af90ae/KOSZULKA-T-SHIRT-MESKA-JHK-TSRA-150-CZARNA-XXL", Price = 16.20 },
                new Product(){ ProductId = 8, Name = "Trousers", Photo = "https://contents.mediadecathlon.com/p298255/ke8f7eea4f12af3b78b529dc7a0923f11/298255_default.jpg?format=auto&quality=60&f=800x0", Price = 15.50 },
                new Product(){ ProductId = 9, Name = "Cap", Photo = "https://az1.hatstoremedia.com/hatstore/images/4978_1/652/522/0/adjustable-black-basic-cap.jpg", Price = 9.99 },
                new Product(){ ProductId = 10, Name = "Blouse", Photo = "https://st2.depositphotos.com/4192645/6758/i/450/depositphotos_67585779-stock-photo-white-hoodie-design.jpg", Price = 20.20 },
                new Product(){ ProductId = 11, Name = "Shorts", Photo = "https://marvel-b1-cdn.bc0a.com/f00000000058595/cdn.shopify.com/s/files/1/0077/0432/products/Khakinators_5_LD_frontweb_400x.progressive.jpg?v=1596760301", Price = 12.90 },
                new Product(){ ProductId = 12, Name = "Sweater", Photo = "https://static.pullandbear.net/2/photos/2020/I/0/1/p/9553/351/804/9553351804_1_1_3.jpg?t=1603984271617", Price = 22.20 },
                new Product(){ ProductId = 13, Name = "T-shirt", Photo = "https://a.allegroimg.com/s512/03a495/6b2048ee4c3297c67532a2af90ae/KOSZULKA-T-SHIRT-MESKA-JHK-TSRA-150-CZARNA-XXL", Price = 16.20 },
                new Product(){ ProductId = 14, Name = "Trousers", Photo = "https://contents.mediadecathlon.com/p298255/ke8f7eea4f12af3b78b529dc7a0923f11/298255_default.jpg?format=auto&quality=60&f=800x0", Price = 15.50 },
                new Product(){ ProductId = 15, Name = "Cap", Photo = "https://az1.hatstoremedia.com/hatstore/images/4978_1/652/522/0/adjustable-black-basic-cap.jpg", Price = 9.99 },
                new Product(){ ProductId = 16, Name = "Blouse", Photo = "https://st2.depositphotos.com/4192645/6758/i/450/depositphotos_67585779-stock-photo-white-hoodie-design.jpg", Price = 20.20 },
                new Product(){ ProductId = 17, Name = "Shorts", Photo = "https://marvel-b1-cdn.bc0a.com/f00000000058595/cdn.shopify.com/s/files/1/0077/0432/products/Khakinators_5_LD_frontweb_400x.progressive.jpg?v=1596760301", Price = 12.90 },
                new Product(){ ProductId = 18, Name = "Sweater", Photo = "https://static.pullandbear.net/2/photos/2020/I/0/1/p/9553/351/804/9553351804_1_1_3.jpg?t=1603984271617", Price = 22.20 }
        };

        // GET: Product
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Product/Buy/5
        public ActionResult Buy(int id)
        {
            return View(products.FirstOrDefault(x => x.ProductId == id));
        }
    }
}
