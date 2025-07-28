using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class HistoryTotalMeritsV
{
    public int? StudentId { get; set; }

    public int? SumOfMeritAmount { get; set; }

    public DateTime? CreatedOn { get; set; }
}
