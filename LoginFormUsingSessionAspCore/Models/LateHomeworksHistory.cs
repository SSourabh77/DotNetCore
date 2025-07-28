using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class LateHomeworksHistory
{
    public int LateHomeworkHistoryId { get; set; }

    public DateTime? DateEntered { get; set; }

    public int? StudentId { get; set; }

    public int? TeacherId { get; set; }

    public string? ExtraInfo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
