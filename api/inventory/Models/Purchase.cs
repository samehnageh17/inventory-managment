using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class Purchase
    {
  public string PurchaseId { get; set; }
    public string ProductId { get; set; }
    public DateTime Timestamp { get; set; }
    public int Quantity { get; set; }
    public decimal UnitCost { get; set; }
    public decimal TotalCost { get; set; }

    // Navigation
    public Product Product { get; set; }
    }
}