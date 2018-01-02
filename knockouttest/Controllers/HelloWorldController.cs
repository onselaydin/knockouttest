using System.Web.Mvc;
using knockouttest.Models;
using PerpetuumSoft.Knockout;
using System.Collections.Generic;

namespace knockouttest.Controllers
{
    public class HelloWorldController : KnockoutController
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            ViewBag.Title = "Hello world";
            return View(new HelloWorldModel
            {
                FirstName = "Steve",
                LastName = "Sanderson"
            });
        }

        public ActionResult Kitaplar()
        {
            var model = new KutuphaneModel
            {
                Kitaplar = new List<KitapModel>
            {
            new KitapModel { Title = "Oliver Twist", Author ="Charles Dickens", Year = 1837 },
            new KitapModel { Title = "Winnie-the-Pooh", Author = "A.A. Milne", Year = 1926 },
            new KitapModel { Title = "The Hobbit", Author = "J. R. R.Tolkien", Year = 1937 },
                }
            };
            return View(model);
        }

    }
}