
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dbdamacana.Models;    

namespace dbdamacana.Controllers{
    public class CartsController : Controller {
       
        public Cartdb dbc = new Cartdb();
        public Productsdb db = new Productsdb();
        public Purchasedb dbp = new Purchasedb();

        public static List<Product> cartproducts = new List<Product>() { };

        // public static List<Cart> carts = new List<Cart>() { };

        //public static List<Purchase> purchases = new List<Purchase>() { };

      
        public ActionResult AddToCart(string Name)
        {
            // TODO find product from this.products
            Product product = new Product(); // lıstenın ıcınde buldugumuz product

            // sepete ekleme işlemi
            foreach (var p in db.Products)
            {
                if (p.Name == Name)
                {
                    product.Name = p.Name;
                    product.Price = p.Price;
                    product.Id = p.Id;
                    cartproducts.Add(p);
                    break;
                }
            }

            return View(product); //sepete eklenmistir goruntusu.
        }





        public ActionResult MyPurchase()
        {
            return View(dbp.purchases);

        }

 public ActionResult DeleteInCart(string Name)
        {
            foreach (Product p in cartproducts)
            {
                if (p.Name == Name)
                {
                    cartproducts.Remove(p);
                    break;
                }
            }
            return View();
        }

 int i = 1;
        public ActionResult Buy()
        {
            Cart cart = new Cart();
            cart.TotalPrice = 0;
            cart.cartproducts = new List<Product>();
            
            cart.UserId = 1;
            Product product = new Product();
            foreach (Product p in cartproducts)
            {
                product.Id = p.Id;
                product.Name = p.Name;
                product.Price = p.Price;
                cart.cartproducts.Add(product);
                cart.TotalPrice += p.Price;
                
            }
            return View(cart);
        }

        public ActionResult MyCart()
        {
            return View(cartproducts);
        }
}}