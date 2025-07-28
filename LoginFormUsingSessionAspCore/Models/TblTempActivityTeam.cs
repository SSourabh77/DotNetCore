using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblTempActivityTeam
{
    public int TempActivityId { get; set; }

    public string? Term { get; set; }

    public string? ActivityName { get; set; }

    public string? TeacherCode { get; set; }

    public string? TeacherName { get; set; }

    public string? StudentCode { get; set; }

    public string? StudentName { get; set; }

    public string? Comments { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
