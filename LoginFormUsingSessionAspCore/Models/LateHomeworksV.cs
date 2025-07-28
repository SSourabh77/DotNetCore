using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class LateHomeworksV
{
    public int LateHomeworkId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? StudentId { get; set; }

    public string? Teacher { get; set; }

    public int Amount { get; set; }

    public string Description { get; set; } = null!;

    public string? ExtraInfo { get; set; }

    public string Type { get; set; } = null!;

    public string? StudentName { get; set; }

    public int? TeacherId { get; set; }
}
