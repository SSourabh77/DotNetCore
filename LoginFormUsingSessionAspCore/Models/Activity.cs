using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class Activity
{
    public int ActivityId { get; set; }

    public string? ActivityName { get; set; }

    public string? TeacherId { get; set; }

    public bool? IsArchived { get; set; }

    public string? Term { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
