using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblWeek
{
    public int WeeksId { get; set; }

    public int? NumberWeek { get; set; }

    public string? Weeks { get; set; }

    public string? RawWeeks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
