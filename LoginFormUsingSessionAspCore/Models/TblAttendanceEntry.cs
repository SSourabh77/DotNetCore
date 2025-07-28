using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblAttendanceEntry
{
    public int EntreyId { get; set; }

    public string Id { get; set; } = null!;

    public DateTime? CheckInOutDate { get; set; }

    public DateTime? CheckInOutTime { get; set; }
}
