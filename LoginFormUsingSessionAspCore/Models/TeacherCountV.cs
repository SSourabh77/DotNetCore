using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TeacherCountV
{
    public int TeacherId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int MeritsGiven { get; set; }

    public int LateHwsGiven { get; set; }

    public int WodemeritsGiven { get; set; }

    public int DemeritsGiven { get; set; }
}
