using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class SatDetAttendance
{
    public int SatDetAttendId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public int? TeacherId { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
