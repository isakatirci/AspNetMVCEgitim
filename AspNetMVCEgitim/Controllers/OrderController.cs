﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitim.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Ekle()
        {
            return View(viewName: "Ekle" );
        }
    }
}