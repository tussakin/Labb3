﻿using System;
using System.Collections.Generic;

namespace Labb3.Models;

public partial class StaffProfession
{
    public int? FkStaffId { get; set; }

    public int? FkProfessionId { get; set; }

    public virtual Profession? FkProfession { get; set; }

    public virtual Staff? FkStaff { get; set; }
}
