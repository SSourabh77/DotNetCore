using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwActivityTeacherName
{
    public int ActivityId { get; set; }

    public string? TeacherId { get; set; }

    public string? Term { get; set; }

    public string? SteacherId { get; set; }

    public string? ActivityName { get; set; }

    public bool? IsArchived { get; set; }

    public string? TeacherName { get; set; }
}
