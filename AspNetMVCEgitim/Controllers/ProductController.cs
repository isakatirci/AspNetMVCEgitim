using AspNetMVCEgitim.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitim.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult YeniEKle(Product product)
        {


            using (SampleDatabase  db = new SampleDatabase())
            {
                product.Id = 1000;
                db.Product.Add(product);
                db.SaveChanges();
            }
          

            //Entity Framework
            using (SampleDatabase db = new SampleDatabase())
            {
                db.Product.ToList();                
            }

            return View();
        }

        public ActionResult Ekle()
        {
            return View(viewName: "Ekle");
        }
    }
}