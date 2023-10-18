using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    // Define a class for employees, inheriting personal information
    public class Employee : Person
    {
        public string Position { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }
        public ContactInformation ContactInfo { get; set; }
        public List<JobHistory> EmploymentHistory { get; set; }

        public Employee(string firstName, string lastName, string position, int salary)
            : base(firstName, lastName)
        {
            Position = position;
            Salary = salary;
            Address = new Address();
            ContactInfo = new ContactInformation();
            EmploymentHistory = new List<JobHistory>();
        }
    }
}
