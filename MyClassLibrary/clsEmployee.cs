using System;

namespace MyClassLibrary
{
    public class clsEmployee
    {
        public string Address { get; set; }
        public string EmployeeContactNumber { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeEmail { get; set; }
        public DateTime EmployeeJoinDate { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeSalary { get; set; }

        public string Valid(string employeeAddress, string employeeContactNumber, string employeeDOB, string employeeEmail, string employeeJoinDate, string employeeName, string employeeRole, string employeeSalary)
        {
            string Error = "";
            if (employeeAddress.Length == 0)
            {
                Error = Error + "The employee address may bot be blank : ";
            }
            if (employeeAddress.Length > 30)
            {
                Error = Error + "The employee address must be 30 characters or less : ";
            }
            if (employeeAddress.Length > 90)
            {
                Error = Error + "The employee address must be less than 90 characters : ";
            }
            if (employeeContactNumber.Length == 0)
            {
                Error = Error + "Contact number can't be wrong ";
            }
            return Error;
        }


    }
}