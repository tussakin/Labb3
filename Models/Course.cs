using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseDescription { get; set; }
}
