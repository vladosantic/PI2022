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
            double UkupniTrosak = 0;
            double UkupniPrihodi = 0;
            foreach(Employees emp in _context.Employees)
            {
                UkupniTrosak += emp.Placa;
            }
            foreach(Equipment eq in _context.Equipment)
            {
                UkupniTrosak += (eq.Kolicina * (eq.CijenaDostave + eq.NabavnaCijena));
            }
            foreach(Jobs jobs in _context.Jobs)
            {
                UkupniTrosak += jobs.CijenaSata * jobs.BrojOsoba * jobs.BrojSati;
                UkupniPrihodi += jobs.Profit;
            }
            double UkupniProfit = UkupniPrihodi - UkupniTrosak;
            ViewBag.UkupniTrosak = UkupniTrosak;
            ViewBag.UkupniPrihodi = UkupniPrihodi;
            ViewBag.UkupniProfit = UkupniProfit;
            List<Test> chartData = new List<Test>
            {
                new Test { xValue = "Ukupni profit", yValue = UkupniProfit},
                new Test { xValue = "Ukupni trošak", yValue = UkupniTrosak},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class Test
        {
            public string xValue;
            public double yValue;
        }
    }
}