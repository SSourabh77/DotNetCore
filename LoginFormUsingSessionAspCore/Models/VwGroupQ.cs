using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwGroupQ
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Gender { get; set; }

    public int? LowerAge { get; set; }

    public int? UpperAge { get; set; }

    public int? MinBirthYear { get; set; }

    public int? MaxBirthYear { get; set; }
}
