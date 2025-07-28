using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Gender { get; set; }

    public int? LowerAge { get; set; }

    public int? UpperAge { get; set; }

    public DateTime? MinBirthYear { get; set; }

    public DateTime? MaxBirthYear { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? Order { get; set; }

    public virtual ICollection<TblEvent> TblEvents { get; set; } = new List<TblEvent>();
}
