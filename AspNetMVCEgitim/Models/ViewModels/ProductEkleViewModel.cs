using AspNetMVCEgitim.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVCEgitim.Models.ViewModels
{
    public class ProductEkleViewModel
    {
        public Product Product { get; set; }
        public DateTime BugununTarihi { get; set; }
        public String  AdiSayadi { get; set; }
    }
}