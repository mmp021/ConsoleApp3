using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    // Define the HR system that manages employees
    public class HRSystem
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        // Hire a new employee
        public void HireEmployee(Employee employee)
        {
            employees.Add(employee.FullName, employee);
        }

        // Promote an employee to a new position
        public void PromoteEmployee(string fullName, string newPosition)
        {
            if (employees.TryGetValue(fullName, out Employee employee))
            {
                employee.Position = newPosition;
            }
            else
            {
                Console.WriteLine("Employee with this name and surname does not exist.");
            }
        }

        // Change an employee's salary
        public void ChangeSalary(string fullName, int newSalary)
        {
            if (employees.TryGetValue(fullName, out Employee employee))
            {
                employee.Salary = newSalary;
            }
            else
            {
                Console.WriteLine("Employee with this name and surname does not exist.");
            }
        }

        // Get an employee's information by full name
        public Employee GetEmployee(string fullName)
        {
            if (employees.TryGetValue(fullName, out Employee employee))
            {
                return employee;
            }
            else
            {
                Console.WriteLine("Employee with this name and surname does not exist.");
                return null;
            }
        }

        // Get a list of all employees
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>(employees.Values);
        }
    }
}
