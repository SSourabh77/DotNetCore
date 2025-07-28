using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class MeritType
{
    public int MeritTypeId { get; set; }

    public string MeritCode { get; set; } = null!;

    public string? MeritDescription { get; set; }

    public int? MeritAmount { get; set; }

    public bool? IsArchived { get; set; }

    public virtual ICollection<MeritEvent> MeritEvents { get; set; } = new List<MeritEvent>();
}
