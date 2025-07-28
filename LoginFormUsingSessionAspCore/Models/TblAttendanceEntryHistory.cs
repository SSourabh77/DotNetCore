using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblAttendanceEntryHistory
{
    public int AttendanceEntryHistoryId { get; set; }

    public int? EntreyId { get; set; }

    public string Id { get; set; } = null!;

    public DateTime? CheckInOutDate { get; set; }

    public DateTime? CheckInOutTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
