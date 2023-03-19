using EMSApp.Models;

namespace EMSApp.Repository.InMemory
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        // it will hold the data in runtime and allow to perfrom crud operations

        static List<Employee> employeeList = new List<Employee>();

        //Department dept = new Department();
        Department dept = new Department();

        static EmployeeInMemoryRepository()
        {
            employeeList.Add(new Employee(1, "Mark", DateTime.Now, "mark@gmail.com", "0911111111"));
            employeeList.Add(new Employee(2, "Kim", DateTime.Now, "kim@gmail.com", "0911111112"));
            employeeList.Add(new Employee(3, "Eduard", DateTime.Now, "ed@gmail.com", "0911111113"));

        }
        public List<Employee> GetAllEmployee()
        {
            return employeeList;
        }

        // get any specific todo
        public Employee GetEmployeesById(int Id)
        {
            return employeeList.FirstOrDefault(x => x.employeeId == Id);
        }

        // add todo into the list
        public Employee AddEmployees(Employee newEmployee)
        {
            newEmployee.employeeId = employeeList.Max(x => x.employeeId) + 1;
            employeeList.Add(newEmployee);
            return newEmployee;
        }

        // update todo in the list
        public Employee UpdateEmployees(int employeeId, Employee newEmployee)
        {
            var oldEmployee = employeeList.Find(x => x.employeeId == employeeId);
            if (oldEmployee == null)
            {
                return null;
            }
            else
            {
                employeeList.Remove(oldEmployee);
                employeeList.Add(newEmployee);
                return newEmployee;
            }
        }

        // delete 
        public Employee DeleteEmployee(int empId)
        {
            var oldEmployee = employeeList.Find(x => x.employeeId == empId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            return oldEmployee;
        }
    }
}
