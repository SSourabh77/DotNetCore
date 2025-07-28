using System;
using System.Collections.Generic;

namespace LoginFormUsingSessionAspCore.Models;

public partial class TblQualification
{
    public int QualificationId { get; set; }

    public string? QualificationName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsArchived { get; set; }

    public virtual ICollection<TblSubject> TblSubjects { get; set; } = new List<TblSubject>();
}
