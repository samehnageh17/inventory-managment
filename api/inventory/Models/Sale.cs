using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class Sale
    {
       public string SaleId { get; set; }
    public string ProductId { get; set; }
    public DateTime Timestamp { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalAmount { get; set; }

    // Navigation
    public Product Product { get; set; }
    }
}