using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course_78_FixList {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int findId = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(id => id.Id == findId);
            
            if(emp != null) {
                Console.Write("Enter the percentage: ");
                emp.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("");
            Console.WriteLine("Updated list of employees:");
            foreach(var item in employees) {
                Console.WriteLine(item);
            }
        }
    }
}
