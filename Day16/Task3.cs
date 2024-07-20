/*
Salary Calculation in a Small Business
Imagine a small business owner who needs to calculate the total salary expenditure for their employees in a given month. The owner uses this program to input the names and respective salaries of the employees and obtain the total salary payout.

User Interaction:
The program starts by asking the business owner to input the number of employees in their company.
For each employee, the owner enters the name and salary.
Once all the employee details are entered, the program calculates the total salary expenditure for all employees combined.
The owner can use this total salary amount for financial planning and budgeting purposes.
 The program allows the business owner to input the names and salaries of their employees. It then calculates and displays the total salary expenditure for all the employees combined. This could aid the owner in managing their financial records and making informed decisions regarding budget allocation and future planning.

Sample Test Case:
Enter the number of employees:
2
Enter name for employee 1:
tarun
Enter salary for employee 1:
44000
Enter name for employee 2:
varun
Enter salary for employee 2:
33000
Total salary of all employees: 77000.0
*/

using System;
class Task3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of employees:");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        double totalSalary = 0;
        for (int i = 1; i <= numberOfEmployees; i++)
        {
            Console.WriteLine("Enter name for employee " + i + ":");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary for employee " + i + ":");
            double salary = double.Parse(Console.ReadLine());

            totalSalary += salary;
        }
        Console.WriteLine("Total salary of all employees: " + totalSalary);
    }
}