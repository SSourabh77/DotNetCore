using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class ActivityHistory
{
    public int? ActivityId { get; set; }

    public string? ActivityName { get; set; }

    public string? TeacherId { get; set; }

    public string? SessionYear { get; set; }

    public bool? IsArchived { get; set; }
}
