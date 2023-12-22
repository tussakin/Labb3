using Labb3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal class GetGrades
    {
        public static void GetLastMonthsGrades()
        {
            using (var DbContext = new SchoolLabb2Context())
            {
                DateTime today = DateTime.Today;
                DateTime FirstDayOfGrades = DateTime.Today.AddDays(-30);

                var GradesLastMonth = DbContext.GradeDetails.Where(Grade => Grade.SetDate >= FirstDayOfGrades && Grade.SetDate <= DateTime.Today).ToList();

                foreach(var GradeDetail in GradesLastMonth)
                {
                    Console.WriteLine($"Grade: {GradeDetail.FkGradeId}, StudentID: {GradeDetail.FkStudentId}");
                }
            }
  
        }
    }
}
