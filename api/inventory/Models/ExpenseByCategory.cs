using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class ExpenseByCategory
    {
 public string ExpenseByCategoryId { get; set; }
    public string ExpenseSummaryId { get; set; }
    public DateTime Date { get; set; }
    public string Category { get; set; }
    public long Amount { get; set; }

    // Navigation
    public ExpenseSummary ExpenseSummary { get; set; }
    }
}