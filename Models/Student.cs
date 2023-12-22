using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public long? SocialSecurityNumber { get; set; }

    public string? Class { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<GradeDetail> GradeDetails { get; set; } = new List<GradeDetail>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
