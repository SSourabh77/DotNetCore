using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblEntryAttendanceStillOutV
{
    public int Id { get; set; }

    public DateTime? LogOutDay { get; set; }

    public string? FullName { get; set; }

    public int? UserId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? ReasonId { get; set; }

    public string? OtherText { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? Location { get; set; }
}
