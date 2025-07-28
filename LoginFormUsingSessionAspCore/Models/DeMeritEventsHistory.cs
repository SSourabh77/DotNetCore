using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class DeMeritEventsHistory
{
    public int DemeritEventHistoryId { get; set; }

    public int? StudentId { get; set; }

    public int? DeMeritTypeId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? TeacherId { get; set; }

    public string? ExtraInfo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
