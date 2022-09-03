using Microsoft.AspNetCore.Mvc;
using PI2022.Data;
using PI2022.Models;

namespace PI2022.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Doughnut Chart - Expense by Category
            //ViewBag.DoughnutChartData = SelectedTransactions
            //    .Where(i => i.Category.Type = "Expense")
            //    .GroupBy(j => j.Category.CategoryId)
            //    .Select(k => new
            //    {
            //        categoryTitleWithIcon = k.First().Category.Icon + " " + k.First().Category.Title,
            //        amount = k.Sum(j => j.Amount),
            //        formattedAmount = k.Sum(j => j.Amount).ToString("C0")
            //    })
            //    .ToList();

            var model = new Dashboard
            {
                Employees = _context.Employees.ToList(),
                Jobs = _context.Jobs.ToList(),
                Equipment = _context.Equipment.ToList()
            };
            return View(model);
        }
    }
}