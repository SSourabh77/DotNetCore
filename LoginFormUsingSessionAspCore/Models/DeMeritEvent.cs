using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class DeMeritEvent
{
    public int DemeritEventId { get; set; }

    public int? StudentId { get; set; }

    public int? DeMeritTypeId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? TeacherId { get; set; }

    public string? ExtraInfo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual DeMeritType? DeMeritType { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
