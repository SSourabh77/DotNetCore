using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblMeetsHistory
{
    public int? MeetId { get; set; }

    public DateOnly? MeetDate { get; set; }

    public string? MeetName { get; set; }

    public int? MeetTypeId { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SessionYear { get; set; }
}
