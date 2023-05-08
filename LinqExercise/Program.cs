using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            //TODO: Print the Average of numbers

            //TODO: Order numbers in ascending order and print to the console

            //TODO: Order numbers in decsending order and print to the console

            //TODO: Print to the console only the numbers greater than 6

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            // List of employees ****Do not remove this****

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //TODO: Add an employee to the end of the list without using employees.Add()


            Console.WriteLine(numbers.Sum());

            Console.WriteLine(numbers.Average());

            var ascendingNumbers = numbers.OrderBy(x => x);
            foreach (var num in ascendingNumbers)
            {
                Console.WriteLine($"num); ");
            }
            Console.WriteLine();

            var descendingNumbers=numbers.OrderBy(x => x);
            foreach (var num in descendingNumbers)
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine();

            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (var num in greaterThanSix) 
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine() ;

            var fourNumbers = numbers.OrderBy(x => x).Take(4);
            foreach (var num in fourNumbers)
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine();

            numbers[4] = 28;
            var modifiedNumbers = numbers.OrderByDescending(x => x);
            foreach (var num in modifiedNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();


            var employees = CreateEmployees();


            var selectedEmployees = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"))
                                            .OrderBy(x => x.FirstName);
            foreach (var emp in selectedEmployees)
            {
                Console.WriteLine(emp.FullName);
            }

            var employeesOver26 = employees.Where(x => x.Age > 26)
                                        .OrderBy(x => x.Age)
                                        .ThenBy(x => x.FirstName);
            foreach (var emp in employeesOver26)
            {
                Console.WriteLine($"{emp.FullName}, {emp.Age}");
            }

            var filteredEmployees = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);
            int sumOfYOE = filteredEmployees.Sum(e => e.YearsOfExperience);
            double averageOfYOE = filteredEmployees.Average(e => e.YearsOfExperience);

            Console.WriteLine("Sum of YearsOfExperience: " + sumOfYOE);
            Console.WriteLine("Average of YearsOfExperience: " + averageOfYOE);


            var newEmployee = new Employee("John", "Doe", 30, 3);
            employees.Insert(employees.Count, newEmployee);




        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
