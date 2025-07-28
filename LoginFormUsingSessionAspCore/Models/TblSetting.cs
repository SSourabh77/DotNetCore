using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblSetting
{
    public int Id { get; set; }

    public int? TimeValue { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
