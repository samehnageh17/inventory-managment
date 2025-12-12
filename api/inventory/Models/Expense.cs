using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory.Models
{
    public class Expense
    {
  public string ExpenseId { get; set; }
    public string Category { get; set; }   // enum stored as string
    public decimal Amount { get; set; }
    public DateTime Timestamp { get; set; }
    }
}