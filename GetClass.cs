using Labb3.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb3
{
    internal class GetClass
    {
        public static void GetClassMenu()
        {
            Console.WriteLine("Classes avalable:");
            using (var dbContext = new SchoolLabb2Context())
            {
                var AllClasses = dbContext.Students.Select(student => student.Class).Distinct();
                foreach (var ClassName in AllClasses)
                {
                    Console.WriteLine(ClassName);
                }
            }
            Console.WriteLine("Enter the name of the class you want to see:");
            string? userInput = Console.ReadLine();


                using (var dbContext = new SchoolLabb2Context())
                {
                    string className = $"{userInput}";

                if (ClassExists(dbContext, className))
                {

                    Student? StudentsClass = dbContext.Students.FirstOrDefault(c => c.Class == className);

                    if (className != null)
                    {
                        Console.WriteLine($"{StudentsClass.FirstName} {StudentsClass.LastName}");
                    }
                    else
                    {
                        Console.WriteLine("You need to enter a valid input.");
                    }
                }
                else
                {
                    Console.WriteLine("We could not find that class.");
                }
                }
        }
        private static bool ClassExists(SchoolLabb2Context dbContext, string className)
        {
            // Check if the class exists in the database
            return dbContext.Students.Any(c => c.Class == className);
        }
    }
    
}
