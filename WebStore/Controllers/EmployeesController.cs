using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebStore.ViewModel;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(IEmployeesData employeesData, ILogger<EmployeesController> logger)
        {
            _employeesData = employeesData;
            _logger = logger;
        }

        public IActionResult Index() => View(_employeesData.GetAll());

        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);

            if (employee is null)
                return NotFound();

            return View(employee);
        }

        public IActionResult Create() => View("Edit", new EmployeeViewModel(0, "", "", "", 0));

        #region Edit

        public IActionResult Edit(int? id)
        {
            if (id is null)
                return View(new EmployeeViewModel(0, "", "", "", 0));

            var employee = _employeesData.GetById((int)id);

            if (employee is null)
                return NotFound();

            var model = new EmployeeViewModel(employee.Id, employee.FirstName, employee.LastName, employee.MiddleName, employee.Age);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            var employee = new Employee(model.Id, model.FirstName, model.LastName, model.MiddleName, model.Age);

            if (employee.Id == 0)
                _employeesData.Add(employee);
            else
                _employeesData.Update(employee);

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete

        public IActionResult Delete(int id)
        {
            var employee = _employeesData.GetById(id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel(employee.Id, employee.FirstName, employee.LastName, employee.MiddleName, employee.Age));
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        } 
        #endregion
    }
}
