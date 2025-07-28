using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class HistoryTotalLateHwsV
{
    public int? StudentId { get; set; }

    public int? TotalLateHomeworks { get; set; }

    public DateTime? CreatedOn { get; set; }
}
