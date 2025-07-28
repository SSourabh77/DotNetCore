using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblActivityTeamHistory
{
    public int? ActivityTeamId { get; set; }

    public int? StudentId { get; set; }

    public string? Term { get; set; }

    public int? ActivityId { get; set; }

    public string? SessionYear { get; set; }
}
