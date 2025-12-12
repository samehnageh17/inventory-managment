using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class SalesSummary
    {
     public string SalesSummaryId { get; set; }
    public decimal TotalValue { get; set; }
    public decimal ChangePercent { get; set; }
    public DateTime Date { get; set; }
    }
}