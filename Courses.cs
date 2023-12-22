using Labb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal class Courses
    { 
    public static void AverageGrades()
    {
            using (var dbContext = new SchoolLabb2Context())
            {
                var courses = dbContext.Courses.OrderBy(course => course.CourseName).ToList();

                foreach (var course in courses)
                {
                    var gradeSum = dbContext.GradeDetails
                        .Where(gradeDetail => gradeDetail.FkCourseId == course.CourseId)
                        .Sum(gradeDetail => gradeDetail.FkGradeId);

                    var numberOfStudents = dbContext.GradeDetails
                        .Count(gradeDetail => gradeDetail.FkCourseId == course.CourseId);

                    // Avoid division by zero
                    var averageGrade = numberOfStudents > 0 ? (double)gradeSum / numberOfStudents : 0;

                    Console.WriteLine($"Course: {course.CourseName} Average grade: {averageGrade}");
                }
            }
        }
}
}
