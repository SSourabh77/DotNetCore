using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblLeaveRequest
{
    public int LeaveId { get; set; }

    public int TeacherId { get; set; }

    public string TeacherCode { get; set; } = null!;

    public string? LeaveType { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Reason { get; set; }

    public string? ApprovalStatus { get; set; }
}
