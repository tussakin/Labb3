using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class GradeDetail
{
    public int GradeDetailId { get; set; }

    public int? FkGradeId { get; set; }

    public int? FkStudentId { get; set; }

    public int? FkCourseId { get; set; }

    public DateTime? SetDate { get; set; }

    public virtual Grade? FkGrade { get; set; }

    public virtual Student? FkStudent { get; set; }
}
