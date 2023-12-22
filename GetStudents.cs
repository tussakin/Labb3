using Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class GetStudents
    {
        public static void GetStudentsMenu()
        {
            Console.WriteLine("Choose what you want to do:");
            Console.WriteLine("1.Print all students after first name in ascending order\n2.Print all students after first name in decending order\n" +
                                "3.Print all students after last name in ascending order\n4.Print all students after last name in decending order");

            string? studentMenu = Console.ReadLine();
            if (int.TryParse(studentMenu, out int menuResult))
            {
                int number = menuResult;
                    switch (number)
                    {
                        case 1:
                            FirstNameAscending();
                            break;
                        case 2:
                            FirstNameDecending();
                            break;
                        case 3:
                            LastNameAscending();
                            break;
                        case 4:
                            LastNameDecending();
                            break;
                        default:
                            Console.WriteLine("You need to enter a valid number!");
                            return;
                    }
            }
            else
            {
                Console.WriteLine("Try again and enter a valid number");
            }

        }
        public static void FirstNameAscending()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var students = dbContext.Students.OrderBy(Student => Student.FirstName).ToList();

                foreach (var Student in students)
                {
                    Console.WriteLine($"{Student.FirstName}  {Student.LastName}");
                }
            }
        }

        public static void FirstNameDecending()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var students = dbContext.Students.OrderByDescending(Student => Student.FirstName).ToList();

                foreach (var Student in students)
                {
                    Console.WriteLine($"{Student.FirstName}  {Student.LastName}");
                }
            }
        }

        public static void LastNameAscending()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var students = dbContext.Students.OrderBy(Student => Student.LastName).ToList();

                foreach (var Student in students)
                {
                    Console.WriteLine($"{Student.LastName}  {Student.FirstName}");
                }
            }
        }

        public static void LastNameDecending() 
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var students = dbContext.Students.OrderByDescending(Student => Student.LastName).ToList();

                foreach (var Student in students)
                {
                    Console.WriteLine($"{Student.LastName}  {Student.FirstName}");
                }
            }
        }
    }
}
