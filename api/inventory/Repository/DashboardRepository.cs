using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Data;
using inventory.Interfaces;
using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ApplicationDBContext _context;
        public DashboardRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<(List<Product> products, List<Sale> sales, List<Purchase> purchases)> getDashboardMetrics()
        {
           var popularProducts= await _context.Products.OrderByDescending(p=>p.StockQuantity).Take(10).ToListAsync();
           var recentSales= await _context.Sales.OrderByDescending(s=>s.TotalAmount).Take(10).ToListAsync();
           
              var recentPurchases= await _context.Purchases.OrderByDescending(p=>p.Quantity).Take(10).ToListAsync();
               
            return (popularProducts, recentSales, recentPurchases);

        }
    }
}