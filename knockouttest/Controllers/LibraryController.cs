using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using knockouttest.Models;
//using PerpetuumSoft.Knockout;

namespace knockouttest.Controllers
{
    public class LibraryController : Controller//KnockoutController
    {

       private static readonly LibraryModel Library = new LibraryModel();

        //Kitap modelden beslenmekte
        public ActionResult Index()
        {
            var model = new KutuphaneModel
            {
               Kitaplar  = new List<KitapModel>
                    {
                    new KitapModel { Title = "Oliver Twist", Author = "Charles Dickens", Year = 1837 },
                    new KitapModel { Title = "Winnie-the-Pooh", Author = "A.A. Milne", Year = 1926 },
                    new KitapModel { Title = "The Hobbit", Author = "J. R. R.Tolkien", Year = 1937 },
                    }
                    };
            return View(model);
        }



        public JsonResult GetName()
        {
            return Json(Library.Name, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetBooks()
        {
            return Json(Library.GetBooks(),
            JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(Library.GetBook(id));
        }
        [HttpPost]
        public ActionResult Edit(BookModel book)
        {
            Library.UpdateBook(book);
            return RedirectToAction("Index");
        }

        public JsonResult Add()
        {
            var book = new BookModel
            {

                Title = "New book",
                Author = "Unknown",
                Year = DateTime.Now.Year
            };
            Library.AddBook(book);
            return Json(Library.GetBooks(),
            JsonRequestBehavior.AllowGet);
        }

        public JsonResult Remove(int id)
        {
            Library.RemoveBook(id);
            return Json(Library.GetBooks(),
            JsonRequestBehavior.AllowGet);
        }


    }
}