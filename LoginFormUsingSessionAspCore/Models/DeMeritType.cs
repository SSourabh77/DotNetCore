using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class DeMeritType
{
    public int DemeritTypeId { get; set; }

    public string DeMeritCode { get; set; } = null!;

    public string? DemeritDescription { get; set; }

    public int? DemeritAmount { get; set; }

    public bool? IsArchived { get; set; }

    public virtual ICollection<DeMeritEvent> DeMeritEvents { get; set; } = new List<DeMeritEvent>();
}
