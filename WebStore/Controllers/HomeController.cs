using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public static readonly List<Employee> EmployeesList = new()
        {
            new Employee(1, "Иван", "Иванов", "Иванович", 30),
            new Employee(2, "Петр", "Петров", "Петрович", 40),
            new Employee(3, "Сидр", "Сидоров", "Сидорович", 25)
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction(int id)
        {
            return Content($"Hello with parameters {id}");
        }

        public IActionResult Employees()
        {
            return View(EmployeesList);
        }

        public IActionResult Details(int id)
        {
            return View(EmployeesList[--id]);
        }
    }
}
