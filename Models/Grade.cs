using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public string? Grade1 { get; set; }

    public int? FkStudentId { get; set; }

    public virtual Student? FkStudent { get; set; }

    public virtual ICollection<GradeDetail> GradeDetails { get; set; } = new List<GradeDetail>();
}
