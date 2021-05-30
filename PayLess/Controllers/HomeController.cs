using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using PayLess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayLess.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PriceResult(Product product)
        {
            SuperMarket ATB = new("ATB", "https://zakaz.atbmarket.com/product/1016/16556?search=%D1%86%D0%B8%D0%B1%D1%83%D0%BB%D1%8F", 7.89, product.Name);
            SuperMarket NashKry = new("Наш край", "http://shop.nashkraj.ua/smila/search/products?cat%5Bproduct_cat_id%5D=%5B%2210401099%22%2C%2210401100%22%2C%2210401101%22%5D&product=%D1%86%D0%B8%D0%B1%D1%83%D0%BB%D1%8F&city=smila&sort=desc&page=2", 10.99, product.Name);
            SuperMarket Rucav = new("Рукавичка", "https://market.rukavychka.ua/cibulja-ripchata-1101020003", 11.90, product.Name);
            
            List<SuperMarket> list = new()
            {
                ATB, NashKry, Rucav
            };
            return View(list);
        }
    }
}
