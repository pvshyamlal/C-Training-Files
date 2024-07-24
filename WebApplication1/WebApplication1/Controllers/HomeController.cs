using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SpendSmartDbContext _context;

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            var allExpenses = _context.Expenses.ToList();
            return View(allExpenses);
        }

        public IActionResult CreateEditExpenses(int id)
        {
            if (id != null)
            {
                var expense = _context.Expenses.FirstOrDefault(Expenses => Expenses.Id == id);
                return View(expense);
            }
            return View();
        }
        public IActionResult DeleteExpense(int id)
        {
            var expensesInDB = _context.Expenses.FirstOrDefault(Expenses => Expenses.Id == id);
            _context.Expenses.Remove(expensesInDB);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditExpense(Expenses model)
        {
                if (model.Id == 0)
                {
                    _context.Expenses.Add(model);
                }
                else
                {
                    _context.Expenses.Update(model);

                }
                _context.SaveChanges();
            return RedirectToAction("Expenses");
        }

        public IActionResult CreateEditExpensesForm(Expenses model)
        {
            _context.Expenses.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
