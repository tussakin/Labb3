using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public int? ProfessionId { get; set; }

    public long? SocialSecurityNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
