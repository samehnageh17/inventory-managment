using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class Product
    {
       public string ProductId { get; set; }      
        public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Rating { get; set; }
    public int StockQuantity { get; set; }

    // Navigation
    public ICollection<Sale> Sales { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
    }
}