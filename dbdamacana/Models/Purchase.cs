using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace dbdamacana.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Product> purchaselist { get; set; }
        public decimal TotalPrice { get; set; }

    }
    public class Purchasedb : DbContext
    {
        public DbSet<Purchase> purchases { get; set; }
    }
}