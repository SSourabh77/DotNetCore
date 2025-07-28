using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblCheckFileLayoutLunch
{
    public int CheckFileLayoutId { get; set; }

    public string? FileType { get; set; }

    public int? NoOfColumn { get; set; }

    public string? FirstColumn { get; set; }

    public string? LastColumn { get; set; }
}
