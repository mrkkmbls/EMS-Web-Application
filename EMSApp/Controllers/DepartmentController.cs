using EMSApp.Models;
using EMSApp.Repository.InMemory;
using Microsoft.AspNetCore.Mvc;

namespace EMSApp.Controllers
{
    public class DepartmentController : Controller
    {

        //DepartmentInMemoryRepository _rep = new DepartmentInMemoryRepository();

        //public IActionResult GetAllDepartments()
        //{
        //    var deptlist = _rep.GetAllDepartment();
        //    return View(deptlist);
        //}

        //public IActionResult Details(int departmentId)
        //{
        //    var emplist = _rep.GetDepartmentById(departmentId);
        //    return View(emplist);
        //}

        //public IActionResult Delete(int departmentId)
        //{
        //    var deptlist = _rep.DeleteDepartment(departmentId);
        //    return RedirectToAction(controllerName: "Department", actionName: "GetAllDepartments");
        //}

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Department newDepartment)
        //{
        //    var dept = _rep.AddDepartment(newDepartment);
        //    return RedirectToAction("GetAllDepartments");
        //}

        //[HttpGet]
        //public IActionResult Update(int departmentId)
        //{
        //    var oldDepartment = _rep.GetDepartmentById(departmentId);
        //    return View(oldDepartment);
        //}


        //[HttpPost]
        //public IActionResult Update(Department newDepartment)
        //{
        //    var dept = _rep.UpdateDepartment(newDepartment.departmentId, newDepartment);
        //    return RedirectToAction("GetAllDepartments");
        //}

    }
}
