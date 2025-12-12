using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Models;

namespace inventory.Interfaces
{
    public interface IDashboardRepository
    {
        Task<(List<Product>products,List<Sale>sales,List<Purchase>purchases)> getDashboardMetrics();
    }
}