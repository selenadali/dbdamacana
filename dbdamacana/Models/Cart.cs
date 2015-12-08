using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dbdamacana.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public List<Product> cartproducts { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class Cartdb : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
    }
}