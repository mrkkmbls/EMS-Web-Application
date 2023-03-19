using EMSApp.Models;

namespace EMSApp.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();

        // get any specific employee
        Employee GetEmployeesById(int Id);


        // add employee into the list
        Employee AddEmployees(Employee newEmployee);


        // update employee in the list
        Employee UpdateEmployees(int employeeId, Employee newEmployee);


        // delete 
        Employee DeleteEmployee(int empId);


    }
}
