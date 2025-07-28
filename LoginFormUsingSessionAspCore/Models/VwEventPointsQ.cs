using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwEventPointsQ
{
    public int? Resultid { get; set; }

    public int? EventId { get; set; }

    public DateOnly? MeetDate { get; set; }

    public string? MeetName { get; set; }

    public bool? NoShow { get; set; }

    public int? MeetId { get; set; }

    public bool? GroupEvent { get; set; }

    public string EventName { get; set; } = null!;

    public int? StudentId { get; set; }

    public string? StudentName { get; set; }

    public int? Result { get; set; }

    public int? Position { get; set; }

    public int? HouseId { get; set; }

    public string? HouseName { get; set; }

    public int? Point1places { get; set; }

    public int? Point2places { get; set; }

    public int? Point3places { get; set; }

    public int? Point4places { get; set; }

    public int? Points { get; set; }

    public int? GroupPoints { get; set; }
}
