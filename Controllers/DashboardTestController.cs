//using Microsoft.AspNetCore.Mvc;
//using PI2022.Data;
//using System.Drawing.Drawing2D;
//using System.Globalization;

//namespace PI2022.Controllers
//{
//    public class DashboardTestController : Controller
//    {
//        private readonly ApplicationDbContext _context;
//        public DashboardTestController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<ActionResult> Index()
//        {
//            // Last 7 Days
//            DateTime StartDate = DateTime.Today.AddDays(-6);
//            DateTime EndDate = DateTime.Today;

//            List<Transaction> SelectedTransactions = await _context.Transactions // nama trebaju place i roba
//                .Include(x => x.Category) //
//                .Where(y => y.Date >= StartDate && y.Date <= EndDate)
//                .ToListAsync();

//            // Total Income
//            int TotalIncome = SelectedTransactions
//                .Where(i => i.Category.Type == "Income")
//                .Sum(j => j.Amount);
//            ViewBag.TotalIncome = TotalIncome.ToString("C0");

//            // Total Expense
//            int TotalExpense = SelectedTransactions
//                .Where(i => i.Category.Type == "Income")
//                .Sum(j => j.Amount);
//            ViewBag.TotalExpense = TotalExpense.ToString("C0");

//            // Balance
//            int Balance = TotalIncome - TotalExpense;
//            // Da izbjegnemo negativnu vrijednosti
//            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
//            culture.NumberFormat.CurrencyNegativePattern = 1;
//            ViewBag.Balance = String.Format(culture, "{0:C0}", Balance);

//            // Doughnut Chart - Expense by Category
//            ViewBag.DoughnutChartData = SelectedTransactions
//                .Where(i => i.Category.Type = "Expense")
//                .GroupBy(j => j.Category.CategoryId)
//                .Select(k => new
//                {
//                    categoryTitleWithIcon = k.First().Category.Icon+" "+ k.First().Category.Title,
//                    amount = k.Sum(j => j.Amount),
//                    formattedAmount = k.Sum(j => j.Amount).ToString("C0")
//                })
//                .ToList();

//            return View();
//        }
//    }
//}
