using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class ExpenseSummary
    {
 public string ExpenseSummaryId { get; set; }
    public decimal TotalExpenses { get; set; }
    public DateTime Date { get; set; }

    // Navigation
    public ICollection<ExpenseByCategory> ExpenseByCategories { get; set; }
    }
}