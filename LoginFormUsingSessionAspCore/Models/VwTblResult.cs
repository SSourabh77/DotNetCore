using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwTblResult
{
    public int StudentId { get; set; }

    public string? StudentCode { get; set; }

    public string? StudentName { get; set; }

    public string? HouseName { get; set; }

    public string? GroupName { get; set; }

    public int? Result { get; set; }

    public int ResultId { get; set; }

    public int EventId { get; set; }

    public int? MeetId { get; set; }

    public int EventTypeId { get; set; }

    public string EventName { get; set; } = null!;

    public bool? TimeEvent { get; set; }

    public int MeetTypeId { get; set; }

    public string? MeetTypeName { get; set; }

    public string? MeetName { get; set; }

    public DateOnly? MeetDate { get; set; }

    public string? StudentGender { get; set; }

    public DateTime? Dob { get; set; }

    public int? Position { get; set; }

    public int? EventNumber { get; set; }
}
