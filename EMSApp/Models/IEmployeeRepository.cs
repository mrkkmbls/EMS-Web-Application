namespace EMSApp.Models
{
    public interface IEmployeeRepository
    {
        List<Department> GetAllEmployee();

        Department GetEmployeeById(int id);

        Department AddEmployee(Department newEmployee);

        Department UpdateEmployee(int employeeId, Department employee);

        Department DeleteEmployee(int employeeId);

    }
}
