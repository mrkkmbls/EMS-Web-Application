using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace EMSApp.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        public string employeeName { get; set;}

        [DataType(DataType.Date)]
        public DateTime employeeDOB { get; set; }

        public string employeeEmail { get; set; }

        public string? employeePhone { get; set; } //doesn't matter if the phone number is blank

        //public Department Department { get; set; }

        //public int DepartmentId { get; set; }

        ////[Required]
       // public Department Department { get; set; }

        public Employee() { }


        public Employee(int id, string name, DateTime dob, string email, string phone)
        {
            this.employeeId = id;
            this.employeeName = name;
            this.employeeDOB = dob;
            this.employeeEmail = email;
            this.employeePhone = phone;

        }


    }
}
