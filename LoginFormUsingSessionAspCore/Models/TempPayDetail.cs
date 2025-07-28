using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TempPayDetail
{
    public string StudentIdcard { get; set; } = null!;

    public int? OrderCount { get; set; }

    public decimal? Pcost { get; set; }

    public decimal? Scost { get; set; }
}
