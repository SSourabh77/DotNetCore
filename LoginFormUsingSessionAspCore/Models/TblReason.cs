using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblReason
{
    public int ReasonId { get; set; }

    public string? ReasonDesc { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblEntryAttendanceInOutLog> TblEntryAttendanceInOutLogs { get; set; } = new List<TblEntryAttendanceInOutLog>();
}
