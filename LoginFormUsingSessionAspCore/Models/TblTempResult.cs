using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblTempResult
{
    public int ResultId { get; set; }

    public int? EventId { get; set; }

    public int? StudentId { get; set; }

    public int? Result { get; set; }

    public bool? NoShow { get; set; }

    public bool? HideRecord { get; set; }

    public int? HeatGroup { get; set; }

    public int? HouseId { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
