using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwListofActivity
{
    public int ActivityId { get; set; }

    public string? ActivityName { get; set; }

    public string? TeacherName { get; set; }

    public int TeacherId { get; set; }
}
