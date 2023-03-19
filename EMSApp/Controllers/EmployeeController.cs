using Microsoft.AspNetCore.Mvc;
using EMSApp.Repository.InMemory;
using EMSApp.Repository;
using EMSApp.Repository.MsSQL;

namespace EMSApp.Controllers
{
    public class EmployeeController : Controller
    { 

        IEmployeeRepository _repo;

        //IEmployeeRepository _repo = new EmployeeInMemoryRepository();
        //IEmployeeRepository _repo1 = new EmployeeDBRepository();


        public EmployeeController(IEmployeeRepository repo) 
        {
            this._repo = repo;
        }

        public IActionResult GetAllEmployees()
        {
            var emplist = _repo.GetAllEmployee();
            return View(emplist);
        }

        public IActionResult Details(int employeeId)
        {
            var emplist = _repo.GetEmployeesById(employeeId);
            return View(emplist);
        }

        public IActionResult Delete(int employeeId)
        {
            var emplist = _repo.DeleteEmployee(employeeId);
            return RedirectToAction(controllerName: "Employee", actionName: "GetAllEmployees");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //the comments is for the validation(cannot create a employee if there is no department)
        [HttpPost]
        public IActionResult Create(Models.Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                var emp = _repo.AddEmployees(newEmployee);
                return RedirectToAction("GetAllEmployees");
            }
            ViewData["Message"] = "Data is not valid to create the employee";
            return View();
        }

        [HttpGet]
        public IActionResult Update(int employeeId)
        {
            var oldEmployee = _repo.GetEmployeesById(employeeId);
            return View(oldEmployee);
        }


        [HttpPost]
        public IActionResult Update(Models.Employee newEmployee)
        {
            var emp = _repo.UpdateEmployees(newEmployee.employeeId, newEmployee);
            return RedirectToAction("GetAllEmployees");
        }


    }
}
