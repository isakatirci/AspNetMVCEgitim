using AspNetMVCEgitim.Models.Entities;
using AspNetMVCEgitim.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitim.Controllers
{
    public class ProductController : Controller
    {
        SampleDatabase db = new SampleDatabase();
        // GET: Product
        public ActionResult YeniEKle(Product product)
        {
        
                product.Id = 1000;
                db.Product.Add(product);
                db.SaveChanges();
                
            //Entity Framework
          
                db.Product.ToList();                
            
            return View();
        }


        //Action - Aksiyon almak
        public ActionResult Ekle()
        {
            ProductEkleViewModel model = new ProductEkleViewModel();
            model.AdiSayadi  = "erdal tekeli";
            model.BugununTarihi = DateTime.Now;
            //İlk kaydı getir
            model.Product = db.Product.FirstOrDefault();           
            return View(viewName: "Ekle",model: model);
        }

        public ActionResult Listele()
        {
            return View(viewName: "Listele");
        }
    }
}