using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Menu
    {

        //A menu that gives the different choices for what the program can do 
        public static void MainMenu()
        {

            while (true)
            {
                Console.WriteLine("1.Get staff");
                Console.WriteLine("2.Get students");
                Console.WriteLine("3.Get class");
                Console.WriteLine("4.Get grades from last month");
                Console.WriteLine("5.Get courses");
                Console.WriteLine("6.Add students");
                Console.WriteLine("7.Add staff");
                Console.WriteLine("Please choose an alternative: ");

                var menuChoice = Console.ReadLine();

                if (int.TryParse(menuChoice, out int number))
                {
                    switch (number)
                    {
                        case 1:
                            GetStaff.GetStaffMenu();
                            break;
                        case 2:
                            GetStudents.GetStudentsMenu();
                            break;
                        case 3:
                            GetClass.GetClassMenu();
                            break;
                        case 4:
                            GetGrades.GetLastMonthsGrades();
                            break;
                        case 5:
                            Courses.AverageGrades();
                            break;
                        case 6:
                            AddStudent.AddStudentMenu();
                            break;
                        case 7:
                            AddStaff.AddStaffMenu();
                            break;

                        default:
                            Console.WriteLine("You need to choose a number from the menu");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You need to choose a valid number");

                }
            }
        }
    }
}
