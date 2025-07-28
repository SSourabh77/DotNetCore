using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class HomeroomsHistory
{
    public int HomeroomsHistoryid { get; set; }

    public int? HomeroomId { get; set; }

    public string? HomeroomCode { get; set; }

    public int? HomeroomYear { get; set; }

    public int? TeacherId { get; set; }

    public string? Deletedby { get; set; }

    public DateTime? DeletedOn { get; set; }
}
