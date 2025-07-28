using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblStudentAccessDatum
{
    public int Studid { get; set; }

    public string? StudentName { get; set; }

    public string? StudentGender { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Houseid { get; set; }

    public string? Studentid { get; set; }
}
