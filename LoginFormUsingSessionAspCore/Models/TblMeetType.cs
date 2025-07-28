using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblMeetType
{
    public int MeetTypeId { get; set; }

    public string? MeetTypeName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<TblMeet> TblMeets { get; set; } = new List<TblMeet>();
}
