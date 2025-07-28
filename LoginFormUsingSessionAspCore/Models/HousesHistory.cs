using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class HousesHistory
{
    public int HousesHistoryId { get; set; }

    public int? HouseId { get; set; }

    public string? HouseName { get; set; }

    public int? TeacherId { get; set; }

    public string? Deletedby { get; set; }

    public DateTime? DeletedOn { get; set; }
}
