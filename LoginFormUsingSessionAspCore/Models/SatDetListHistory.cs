using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class SatDetListHistory
{
    public int SatDetHistoryId { get; set; }

    public int StudentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
