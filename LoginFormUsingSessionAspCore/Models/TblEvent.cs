using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblEvent
{
    public int EventId { get; set; }

    public int? EventNumber { get; set; }

    public int? MeetId { get; set; }

    public int? EventTypeId { get; set; }

    public int? GroupId { get; set; }

    public DateTime? EventTime { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool FilledIn { get; set; }

    public bool? Scored { get; set; }

    public virtual TblEventType? EventType { get; set; }

    public virtual TblGroup? Group { get; set; }

    public virtual TblMeet? Meet { get; set; }

    public virtual ICollection<TblResult> TblResults { get; set; } = new List<TblResult>();
}
