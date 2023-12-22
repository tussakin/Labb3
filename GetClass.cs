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
        //Menu for fetching the class. It loops through classes that exsists and then lets user write what clas they want to show
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

                    var StudentsClass = dbContext.Students.Where(c => c.Class == className).ToList();

                    if (className != null)
                    {
                        foreach (var Students in StudentsClass)
                        {
                            Console.WriteLine($"{Students.FirstName} {Students.LastName}");
                        }
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
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        //Checks if the class exsists 
        private static bool ClassExists(SchoolLabb2Context dbContext, string className)
        {
            // Check if the class exists in the database
            return dbContext.Students.Any(c => c.Class == className);
        }
    }

}
