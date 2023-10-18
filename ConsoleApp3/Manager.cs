using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    // Define a class for managers, inheriting employee information
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string firstName, string lastName, string position, int salary, string department)
            : base(firstName, lastName, position, salary)
        {
            Department = department;
        }
    }
}
