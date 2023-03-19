using Microsoft.EntityFrameworkCore;
using EMSApp.Models;
using EMSApp.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EMSApp.Repository.MsSQL
{
    public class EmployeeDBRepository : IEmployeeRepository
    {
        //EmployeeDBRepository employeeDB = new EmployeeDBRepository();

        EmployeeDbContext _dbEmployeeContext = new EmployeeDbContext();

        public EmployeeDBRepository(EmployeeDbContext dbContext)
        {
            _dbEmployeeContext = dbContext;
        }

        public Employee AddEmployees(Models.Employee newEmployee)
        {
            _dbEmployeeContext.Add(newEmployee);
            _dbEmployeeContext.SaveChanges();
            return newEmployee;
        }

        public Employee DeleteEmployee(int empId)
        {
            var emp = GetEmployeesById(empId);
            if (emp != null)
            {
                _dbEmployeeContext.Employees.Remove(emp);
                _dbEmployeeContext.SaveChanges();
            }
            return emp;
        }

        public List<Employee> GetAllEmployee()
        {
            return _dbEmployeeContext.Employees.ToList();
        }

        public Employee GetEmployeesById(int Id)
        {
            return _dbEmployeeContext.Employees.AsNoTracking().ToList().FirstOrDefault(t => t.employeeId == Id);
        }

        public Employee UpdateEmployees(int employeeId, Models.Employee newEmployee)
        {
            _dbEmployeeContext.Employees.Update(newEmployee);
            _dbEmployeeContext.SaveChanges();
            return newEmployee;
        }
    }
}
