using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class VwNumberOfParticipant
{
    public string EventName { get; set; } = null!;

    public int? EventNumber { get; set; }

    public int EventId { get; set; }

    public string? Group { get; set; }

    public DateTime? Time { get; set; }

    public string? Type { get; set; }

    public int MeetId { get; set; }

    public string? Meet { get; set; }

    public DateOnly? Date { get; set; }

    public int? Participants { get; set; }

    public bool? Scored { get; set; }
}
