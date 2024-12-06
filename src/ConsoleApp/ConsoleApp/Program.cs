using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var employee in context.Employee.ToList())
                {
                    Console.WriteLine($"Id: {employee.Id}, First name: {employee.First_Name}, Last name: {employee.Last_Name}");
                }
            }
        }
    }
}