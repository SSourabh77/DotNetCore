using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class HomeworkClubAttendanceHistory
{
    public int HomeworkCludAttendHistoryId { get; set; }

    public int? StudentId { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public int? TeacherId { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
