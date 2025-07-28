using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class DeMeritWorkOffEvent
{
    public int DemeritWorkOffEventId { get; set; }

    public int? DeMeritWorkOffTypeId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? StudentId { get; set; }

    public string? ExtraInfo { get; set; }

    public int? TeacherId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual DeMeritWorkOffType? DeMeritWorkOffType { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
