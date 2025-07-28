using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class DeMeritWorkOffType
{
    public int DemeritWorkOffTypeId { get; set; }

    public string? WorkOffCode { get; set; }

    public string? WorkOffDescription { get; set; }

    public int? WorkOffAmount { get; set; }

    public virtual ICollection<DeMeritWorkOffEvent> DeMeritWorkOffEvents { get; set; } = new List<DeMeritWorkOffEvent>();
}
