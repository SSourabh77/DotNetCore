using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwStudentAttendanceSupportLounge
{
    public string? StudentName { get; set; }

    public string? StudentCode { get; set; }

    public string? YearGroup { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public DateTime? FirstCheckInTime { get; set; }

    public int? FirstCheckInLevel { get; set; }

    public DateTime? LastCheckOutTime { get; set; }

    public int? LastCheckOutLevel { get; set; }

    public TimeOnly? TotalTime { get; set; }

    public int? LevelDifference { get; set; }
}
