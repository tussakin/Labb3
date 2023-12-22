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
            Console.WriteLine("Choose what class you want to print:");
            Console.WriteLine("1.5a\n2.5b\n3.5c\n4.5c\n5.6a\n6.6b\n7.6c\n8.7a\n9.7b\n10.7c\n11.7d\n12.8a\n13.8b\n14.8c\n15.8d\n16.9a\n17.9b\n18.9c\n19.9d\n20.9e");
            string? userInput = Console.ReadLine();


                using (var dbContext = new SchoolLabb2Context())
                {
                    string className = $"{userInput}";

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
        }
    }
}
