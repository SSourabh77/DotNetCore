using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class MeritEvent
{
    public int MeritEventId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? StudentId { get; set; }

    public int? MeritTypeId { get; set; }

    public int? TeacherId { get; set; }

    public string? ExtraInfo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual MeritType? MeritType { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
