using Labb3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class GetStaff
    {

        //Gives the different alternatives in a menu
        public static void GetStaffMenu()
        {
            Console.WriteLine("Choose what you want to do:");
            Console.WriteLine("1.Print all staff \n2.Print all teachers \n3.Print all principals\n4.Print all janitors\n5.Print all teacher aids\n6.Print all Lunch staff\n7.Print all guidance counselors");

            string? staffMenu = Console.ReadLine();
            if (int.TryParse(staffMenu, out int menuResult))
            {
                int number = menuResult;

                switch (number)
                {
                    case 1:
                        PrintAllStaff();
                        break;
                    case 2:
                        PrintAllTeachers();
                        break;
                    case 3:
                        PrintAllPrincipals();
                        break;
                    case 4:
                        PrintAllJanitors();
                        break;
                    case 5:
                        PrintAllTeacherAids();
                        break;
                    case 6:
                        PrintAllLunchStaff();
                        break;
                    case 7:
                        PrintAllGuidanceCouncelors();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Try again and enter a valid number");
            }

        }

        //Prints all staff
        public static void PrintAllStaff()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var Staff = dbContext.Staff.ToList();

                foreach (var staff in Staff)
                {
                    Console.WriteLine($"Staff ID: {staff.StaffId}, {staff.FirstName} {staff.LastName}");
                }
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();

        }

        //Prints all teachers
        static void PrintAllTeachers()
        {
            using var dbContext = new SchoolLabb2Context();
            
                var teachers = dbContext.Staff.Where(staff => staff.ProfessionId == 1);

                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Teacher {teacher.FirstName} {teacher.LastName}");
                }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        //Prints all principals 
        static void PrintAllPrincipals()
        {
            using var dbContext = new SchoolLabb2Context();
            var principals = dbContext.Staff.Where(staff => staff.ProfessionId == 2);

            foreach (var principal in principals)
            {
                Console.WriteLine($"Principal {principal.FirstName} {principal.LastName}");
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }


        //Prints all janitors
        static void PrintAllJanitors()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var janitors = dbContext.Staff.Where(staff => staff.ProfessionId == 3);

                foreach (var janitor in janitors)
                {
                    Console.WriteLine($"Janitor {janitor.FirstName} {janitor.LastName}");
                }
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }

        // Prints all teachers aids 
        static void PrintAllTeacherAids()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var teachersAids = dbContext.Staff.Where(staff => staff.ProfessionId == 4);

                foreach (var teacherAid in teachersAids)
                {
                    Console.WriteLine($"Teachers Aid {teacherAid.FirstName} {teacherAid.LastName}");
                }
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }


        //Prints all lunch staff
        static void PrintAllLunchStaff()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var lunchStaffs = dbContext.Staff.Where(staff => staff.ProfessionId == 5);

                foreach (var lunchStaff in lunchStaffs)
                {
                    Console.WriteLine($"Lunch Staff {lunchStaff.FirstName} {lunchStaff.LastName}");
                }
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }


        // Prints all guidance councelors 
        static void PrintAllGuidanceCouncelors()
        {
            using (var dbContext = new SchoolLabb2Context())
            {
                var guidanceCouncelors = dbContext.Staff.Where(staff => staff.ProfessionId == 6);

                foreach (var guidanceCouncelor in guidanceCouncelors)
                {
                    Console.WriteLine($"Guidance Councelor {guidanceCouncelor.FirstName} {guidanceCouncelor.LastName}");
                }
            }
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
