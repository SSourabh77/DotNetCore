using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class StudentInfo
{
    public int StudentInfoId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? YearGroup { get; set; }

    public string? RegGroup { get; set; }

    public int? StudentId { get; set; }
}
