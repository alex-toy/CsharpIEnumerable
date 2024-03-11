using IEnumerableApp.Models;
using Microsoft.AspNetCore.Mvc;
using Products.API.DbContexts;
using System.Diagnostics;

namespace IEnumerableApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ToDo> ienum_todos = _db.ToDos;
            ICollection<ToDo> icoll_todos = _db.ToDos.ToList();
            IList<ToDo> ilist_todos = _db.ToDos.ToList();

            Console.WriteLine("** IEnumerable ******************************");
            foreach (var todo in ienum_todos) Console.WriteLine($"{todo.Item}");

            Console.WriteLine("** ICollection ******************************");
            foreach (var todo in icoll_todos) Console.WriteLine($"{todo.Item}");

            Console.WriteLine("** IList ******************************");
            foreach (var todo in ilist_todos) Console.WriteLine($"{todo.Item}");

            ToDo toDo = new ToDo() { Id = 5, Item = "Hello" };

            //ienum_todos.Add(toDo); doesn't work
            icoll_todos.Add(toDo);
            ilist_todos.Add(toDo);

            //ienum_todos.Remove(toDo); doesn't work
            icoll_todos.Remove(toDo);
            ilist_todos.Remove(toDo);

            //ienum_todos.Insert(3, toDo); doesn't work
            //icoll_todos.Insert(3, toDo); doesn't work
            ilist_todos.Insert(3, toDo);

            //ienum_todos.Insert(3); doesn't work
            //icoll_todos.Insert(3); doesn't work
            ilist_todos.RemoveAt(3);

            //differed execution
            var ienum_first1 = ienum_todos.FirstOrDefault();
            var ienum_first2 = ienum_todos.FirstOrDefault(u => u.Item.Contains("c"));
            var ienum_first3 = ienum_todos.Count();

            var icoll_first1 = ienum_todos.FirstOrDefault();
            var icoll_first2 = ienum_todos.FirstOrDefault(u => u.Item.Contains("c"));
            var icoll_first3 = ienum_todos.Count();

            return View();
        }

        public IActionResult Enumerables()
        {
            IEnumerable<Employee> employees = _db.Employees; // loading the employee table
            foreach (var employee in employees) Console.WriteLine($"{employee.Name}");

            //IEnumerable<Employee> employees1 = employees.Where(e => e.Salary >= 50000).ToList();
            //foreach (var employee in employees1) Console.WriteLine($"{employee.Name}");

            IQueryable<Employee> employees2 = _db.Employees.Where(e => e.Salary >= 50000);
            foreach (var employee in employees2) Console.WriteLine($"{employee.Name}");

            IQueryable<Employee> employees3 = employees.AsQueryable().Where(e => e.Salary >= 50000);
            foreach (var employee in employees3) Console.WriteLine($"{employee.Name}");

            return View("Index");
        }

        public IActionResult Customers()
        {
            IQueryable<Customer> customers_iquer = _db.Customers.AsQueryable();
            IEnumerable<Customer> customers_ienum= _db.Customers.AsEnumerable();

            IEnumerable<Customer> highRevenueCustomers = customers_ienum.Where(c => c.Revenue > 50000);
            IEnumerable<Customer> lowRevenueCustomers = customers_iquer.Where(c => c.Revenue < 50000);

            var temp = highRevenueCustomers.ToList();
            var temp2 = lowRevenueCustomers.ToList();


            return View("Index");
        }
    }
}
