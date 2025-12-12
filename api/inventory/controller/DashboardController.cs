using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Data;
using inventory.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace inventory.controller
{
    [Route("api/Dashboard")]
    [ApiController]
    public class DashboardController: ControllerBase
    {
      private readonly ApplicationDBContext _context;
      private readonly IDashboardRepository
        _dashboardRepository;
        public DashboardController(ApplicationDBContext context,IDashboardRepository dashboardRepository)
        {
            _context = context;
            _dashboardRepository = dashboardRepository;
        }
        [HttpGet("GetDashboardData")]
        public async Task<IActionResult> GetDashboardData()
        {
            try
            {
                var dashboardData = await _dashboardRepository.getDashboardMetrics();
                return Ok(dashboardData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}