using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class LateHomework
{
    public int LateHomeworkId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? StudentId { get; set; }

    public int? TeacherId { get; set; }

    public string? ExtraInfo { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Student? Student { get; set; }
}
