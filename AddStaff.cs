﻿using Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    // Add staff
    internal class AddStaff
    {
        public static void AddStaffMenu()
        {
            // Takes input 

            Console.WriteLine("Please enter the first name of the staffmember:");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the staffmember:");
            string? lastName = Console.ReadLine();
            long socialSecurityNumber = 0;
            int staffRole = 0;

            // While loop that continues until the staffmembers social security number has been added correctly
            while (true)
            {
                Console.WriteLine("Please enter the social security number of the staffmember:");
                if (long.TryParse(Console.ReadLine(), out socialSecurityNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You need to enter a valid social security number.");
                }
            }

            //While loop that continues until the staffmembers role has been entered correctly

            while (true)
            {
                Console.WriteLine("1.Teacher\n2.Principal\n3.Janitor\n4.Teachers aid\n5.Lunch staf\n6.Guidance counselor");
                Console.WriteLine("Please enter what role the staffmember has:");
                if (int.TryParse(Console.ReadLine(), out staffRole))
                {
                    if (staffRole <= 6 && staffRole >= 1)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("You need to enter a valid number between 1 and 6.");
                    }
                }
            }

            // Calls on AddNewStaff that adds a new staf to the database and then saves it
            AddNewStaff(firstName, lastName, socialSecurityNumber, staffRole);
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void AddNewStaff(string firstName, string lastName, long socialSecurityNumber, int staffRole)
        {
            using var dbContext = new SchoolLabb2Context();
            var newStaff = new Staff
            {
                FirstName = firstName,
                LastName = lastName,
                SocialSecurityNumber = socialSecurityNumber,
                ProfessionId = staffRole
            };

            dbContext.Staff.Add(newStaff);
            dbContext.SaveChanges();
        }
    }
}
