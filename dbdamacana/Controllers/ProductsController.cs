using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dbdamacana.Models;


namespace dbdamacana.Controllers
{
    public class ProductsController : Controller
    {
        private Productsdb db = new Productsdb();
              
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        
   
        public ActionResult AddProduct(Product product)
        {
            return View(product);
        }

       
        public ActionResult SaveProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return View(product);
        }
    
       
        public ActionResult EditProduct(string Name)
        {
            Product product = new Product();
            foreach (Product p in db.Products)
            {
                if (p.Name == Name)
                {
                    product.Name = p.Name;
                    product.Price = p.Price;
                    product.Id = p.Id;
                   
                    db.Products.Remove(p);
                    break;
                }
                
            }
            db.SaveChanges();
            return View(product);
        }
        public ActionResult Editt(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return View(product);
        }


        public ActionResult DeleteProduct(string Name)
        {

            foreach (Product p in db.Products)
            {
                if (p.Name == Name)
                {
                    db.Products.Remove(p);
                    break;
                }
            }

            db.SaveChanges();
            return View();
        }

      
    }
}