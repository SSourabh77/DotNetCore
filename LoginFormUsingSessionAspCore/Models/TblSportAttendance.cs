using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblSportAttendance
{
    public int SportAttendanceId { get; set; }

    public string? Term { get; set; }

    public int? StudentId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public int? ActivityId { get; set; }

    public string? Attened { get; set; }

    public string? Notes { get; set; }
}
