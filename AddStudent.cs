using Labb3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal class AddStudent
    {
        public static void AddStudentMenu()
        {
            try
            {

            
            Console.WriteLine("Please enter the first name of the student:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the student:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter the social security number of the student:");
                if (long.TryParse(Console.ReadLine(), out long socialSecurityNumber))
                {
                    Console.WriteLine("Please enter the name of the class that the student belongs to:");
                    string className = Console.ReadLine();
                    while (true)
                    {
                        Console.WriteLine("Please enter the gender of the student (f or m):");
                        string gender = Console.ReadLine();
                        if (gender == "f" || gender == "m")
                        {
                            AddNewStudent(firstName, lastName, socialSecurityNumber, className, gender);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 'f' or 'm'");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid social security number. Please enter a valid number.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error {ex}");
            }
        }
        public static void AddNewStudent(string firstName, string lastName, long socialSecurityNumber, string className, string gender)
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var newStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    SocialSecurityNumber = socialSecurityNumber,
                    Class = className,
                    Gender = gender
                };
            
            dbContext.Students.Add(newStudent);
            dbContext.SaveChanges();
            }
    }
    }
}
