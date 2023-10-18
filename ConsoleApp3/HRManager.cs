using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    // Define an HR manager to interact with the HR system
    public class HRManager
    {
        // Method to manage the HR system
        public void ManageHRSystem()
        {
            HRSystem hrSystem = new HRSystem();

            try
            {
                // Hire a new employee
                Employee employee1 = new Employee("John", "Doe", "Engineer", 100000);
                hrSystem.HireEmployee(employee1);

                // Promote an employee to a new position
                hrSystem.PromoteEmployee(employee1.FullName, "Manager");

                // Change an employee's salary
                hrSystem.ChangeSalary(employee1.FullName, 120000);

                // Get employee information
                Employee employee = hrSystem.GetEmployee(employee1.FullName);
                if (employee != null)
                {
                    Console.WriteLine("First Name: {0}", employee.FirstName);
                    Console.WriteLine("Last Name: {0}", employee.LastName);
                    Console.WriteLine("Position: {0}", employee.Position);
                    Console.WriteLine("Salary: {0}", employee.Salary);
                }

                // Get a list of all employees
                List<Employee> employees = hrSystem.GetAllEmployees();
                foreach (Employee emp in employees)
                {
                    Console.WriteLine("First Name: {0}", emp.FirstName);
                    Console.WriteLine("Last Name: {0}", emp.LastName);
                    Console.WriteLine("Position: {0}", emp.Position);
                    Console.WriteLine("Salary: {0}", emp.Salary);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
