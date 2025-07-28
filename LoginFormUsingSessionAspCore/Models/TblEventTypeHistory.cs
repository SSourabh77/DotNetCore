using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblEventTypeHistory
{
    public int? EventTypeId { get; set; }

    public string? EventName { get; set; }

    public int? Point1Places { get; set; }

    public int? Point2Places { get; set; }

    public int? Point3Places { get; set; }

    public int? Point4Places { get; set; }

    public bool? TimeEvent { get; set; }

    public int? MeetTypeId { get; set; }

    public bool? GroupEvent { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SessionYear { get; set; }
}
