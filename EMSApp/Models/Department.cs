namespace EMSApp.Models
{
    public class Department
    {
        public int departmentId { get; set; }

        public string departmentName { get; set;}

        public List<Employee> Employees { get; set; }

        //public Department() { }

        //public Department(int departmentId, string departmentName)
        //{
        //    this.departmentId = departmentId;
        //    this.departmentName = departmentName;
        //}
    }
}
