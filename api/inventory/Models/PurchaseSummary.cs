using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class PurchaseSummary
    {
   public string PurchaseSummaryId { get; set; }
    public decimal TotalPurchased { get; set; }
    public decimal ChangePercent { get; set; }
    public DateTime Date { get; set; }
    }
}